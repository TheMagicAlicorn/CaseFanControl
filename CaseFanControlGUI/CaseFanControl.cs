using OpenHardwareMonitor.Hardware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseFanControlGUI {
    public partial class CaseFanControl : Form {
        public CaseFanControl() {
            InitializeComponent();
        }

        private void CaseFanControl_Load(object sender, EventArgs e) {
            gpuTemp.Text = " °C";
            fanSpeed.Text = " RPM";
            getInfotimer.Enabled = true;
        }

        private void getInfotimer_Tick(object sender, EventArgs e) {
            GetSysInfos();
        }
        public class UpdateVisitor : IVisitor {
            public void VisitComputer(IComputer computer) {
                computer.Traverse(this);
            }
            public void VisitHardware(IHardware hardware) {
                hardware.Update();
                foreach (IHardware subHardware in hardware.SubHardware) subHardware.Accept(this);
            }
            public void VisitSensor(ISensor sensor) { }
            public void VisitParameter(IParameter parameter) { }
        }
        public void GetSysInfos() {
            UpdateVisitor updateVisitor = new UpdateVisitor();
            Computer computer = new Computer();
            computer.Open();
            computer.Accept(updateVisitor);
            computer.GPUEnabled = true;
            
            foreach(var hardwareItem in computer.Hardware) {
                if(hardwareItem.HardwareType == HardwareType.GpuNvidia) {
                    foreach(var sensor in hardwareItem.Sensors) {
                        if(sensor.SensorType == SensorType.Temperature)
                            gpuTemp.Text = $"{sensor.Value} °C";
                    }
                }
                if(hardwareItem.HardwareType == HardwareType.Mainboard) {
                    foreach(var subhardware in hardwareItem.SubHardware) {
                        subhardware.Update();
                        if(subhardware.Sensors.Length > 0) {
                            foreach (var sensor in subhardware.Sensors) {
                                if (sensor.SensorType == SensorType.Fan && sensor.Name.Equals("AUXFANIN0"))
                                    fanSpeed.Text = $"{sensor.Value} RPM";
                            }
                        }    
                    }
                }
            }
        }
    }
}
