using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using OpenHardwareMonitor.Hardware;

namespace CaseFanControl {
    public partial class MainService : ServiceBase {
        public MainService() {
            InitializeComponent();
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

            foreach (var hardwareItem in computer.Hardware) {
                if (hardwareItem.HardwareType == HardwareType.GpuNvidia) {
                    foreach (var sensor in hardwareItem.Sensors) {
                        if (sensor.SensorType == SensorType.Temperature)
                            return (int)sensor.Value;
                    }
                }
            }
            computer.Close();
            return 0;
        }

        protected override void OnStart(string[] args) {
        }

        protected override void OnStop() {
        }
    }
}
