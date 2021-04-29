
namespace CaseFanControlGUI {
    partial class CaseFanControl {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.silentButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gpuTemp = new System.Windows.Forms.Label();
            this.fanSpeed = new System.Windows.Forms.Label();
            this.GetInfotimer = new System.Windows.Forms.Timer(this.components);
            this.userDesiredSpeed = new System.Windows.Forms.NumericUpDown();
            this.SetSpeedButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userDesiredSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // silentButton
            // 
            this.silentButton.Location = new System.Drawing.Point(13, 107);
            this.silentButton.Name = "silentButton";
            this.silentButton.Size = new System.Drawing.Size(75, 23);
            this.silentButton.TabIndex = 0;
            this.silentButton.Text = "Silent Mode";
            this.silentButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "GPU Temp :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Case Fans Speed :";
            // 
            // gpuTemp
            // 
            this.gpuTemp.AutoSize = true;
            this.gpuTemp.Location = new System.Drawing.Point(85, 13);
            this.gpuTemp.Name = "gpuTemp";
            this.gpuTemp.Size = new System.Drawing.Size(21, 13);
            this.gpuTemp.TabIndex = 3;
            this.gpuTemp.Text = " °C";
            // 
            // fanSpeed
            // 
            this.fanSpeed.AutoSize = true;
            this.fanSpeed.Location = new System.Drawing.Point(116, 37);
            this.fanSpeed.Name = "fanSpeed";
            this.fanSpeed.Size = new System.Drawing.Size(34, 13);
            this.fanSpeed.TabIndex = 4;
            this.fanSpeed.Text = " RPM";
            // 
            // GetInfotimer
            // 
            this.GetInfotimer.Enabled = true;
            this.GetInfotimer.Interval = 1000;
            this.GetInfotimer.Tick += new System.EventHandler(this.GetInfotimer_Tick);
            // 
            // userDesiredSpeed
            // 
            this.userDesiredSpeed.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.userDesiredSpeed.Location = new System.Drawing.Point(16, 67);
            this.userDesiredSpeed.Maximum = new decimal(new int[] {
            2400,
            0,
            0,
            0});
            this.userDesiredSpeed.Minimum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.userDesiredSpeed.Name = "userDesiredSpeed";
            this.userDesiredSpeed.Size = new System.Drawing.Size(76, 20);
            this.userDesiredSpeed.TabIndex = 6;
            this.userDesiredSpeed.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // SetSpeedButton
            // 
            this.SetSpeedButton.Location = new System.Drawing.Point(102, 64);
            this.SetSpeedButton.Name = "SetSpeedButton";
            this.SetSpeedButton.Size = new System.Drawing.Size(75, 25);
            this.SetSpeedButton.TabIndex = 7;
            this.SetSpeedButton.Text = "Set Speed";
            this.SetSpeedButton.UseVisualStyleBackColor = true;
            this.SetSpeedButton.Click += new System.EventHandler(this.SetSpeedButton_Click);
            // 
            // CaseFanControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 142);
            this.Controls.Add(this.SetSpeedButton);
            this.Controls.Add(this.userDesiredSpeed);
            this.Controls.Add(this.fanSpeed);
            this.Controls.Add(this.gpuTemp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.silentButton);
            this.Name = "CaseFanControl";
            this.Text = "Case Fan Control";
            ((System.ComponentModel.ISupportInitialize)(this.userDesiredSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button silentButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label gpuTemp;
        private System.Windows.Forms.Label fanSpeed;
        private System.Windows.Forms.Timer GetInfotimer;
        private System.Windows.Forms.NumericUpDown userDesiredSpeed;
        private System.Windows.Forms.Button SetSpeedButton;
    }
}

