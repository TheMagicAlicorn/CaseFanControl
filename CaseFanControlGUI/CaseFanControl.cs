using OpenHardwareMonitor.Hardware;
using System;
using System.Runtime.InteropServices;
using System.Management;
using System.Windows.Forms;

namespace CaseFanControlGUI {
    public partial class CaseFanControl : Form {
        public CaseFanControl() {
            InitializeComponent();
        }

        private void GetInfotimer_Tick(object sender, EventArgs e) {
            gpuTemp.Text = $"{GetGPUTemp()} °C";
            fanSpeed.Text = $"{GetFanSpeed()} RPM";
        }
        [DllImport("cimwin32.dll")] static extern UInt32 SetSpeed(in UInt64 DesiredSpeed);
        public void SetSpeedButton_Click(object sender, EventArgs e) {
            ManagementClass fanClass = new ManagementClass("\\\\.\\ROOT\\cimv2" + ":" + "CIM_FAN");
            ManagementBaseObject inParams = fanClass.GetMethodParameters("SetSpeed");
            inParams["DesiredSpeed"] = userDesiredSpeed.Value;
            ManagementBaseObject outParams = fanClass.InvokeMethod("SetSpeed", inParams, null);
            //fanClass .InvokeMethod("SetSpeed", null);
            //SetSpeed((UInt64)userDesiredSpeed.Value);
        }

        public class UpdateVisitor : IVisitor {
            public void VisitComputer(IComputer computer) {
                computer.Traverse(this);
            }
            public void VisitHardware(IHardware hardware) { }
            public void VisitSensor(ISensor sensor) { }
            public void VisitParameter(IParameter parameter) { }
        }

        public int GetGPUTemp() {
            UpdateVisitor updateVisitor = new UpdateVisitor();
            Computer computer = new Computer();
            computer.Open();
            computer.Accept(updateVisitor);
            computer.GPUEnabled = true;
            
            foreach(var hardwareItem in computer.Hardware) {
                if(hardwareItem.HardwareType == HardwareType.GpuNvidia) {
                    foreach(var sensor in hardwareItem.Sensors) {
                        if (sensor.SensorType == SensorType.Temperature)
                            return (int)sensor.Value;
                    }
                }
            }
            computer.Close();
            return 0;
        }

        public int GetFanSpeed() {
            UpdateVisitor updateVisitor = new UpdateVisitor();
            Computer computer = new Computer();
            computer.Open();
            computer.Accept(updateVisitor);
            computer.MainboardEnabled = true;

            foreach (var hardwareItem in computer.Hardware) {
                if (hardwareItem.HardwareType == HardwareType.Mainboard) {
                    foreach (var subhardware in hardwareItem.SubHardware) {
                        subhardware.Update();
                        if (subhardware.Sensors.Length > 0) {
                            foreach (var sensor in subhardware.Sensors) {
                                if (sensor.SensorType == SensorType.Fan && sensor.Name.Equals("Fan #3"))
                                    return (int)sensor.Value;
                            }
                        }
                    }
                }
            }
            computer.Close();
            return 0;
        }
    }
}
