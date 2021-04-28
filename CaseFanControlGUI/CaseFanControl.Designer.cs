
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
            this.getInfotimer = new System.Windows.Forms.Timer(this.components);
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
            this.gpuTemp.Size = new System.Drawing.Size(63, 13);
            this.gpuTemp.TabIndex = 3;
            this.gpuTemp.Text = "GPU TEMP";
            // 
            // fanSpeed
            // 
            this.fanSpeed.AutoSize = true;
            this.fanSpeed.Location = new System.Drawing.Point(117, 37);
            this.fanSpeed.Name = "fanSpeed";
            this.fanSpeed.Size = new System.Drawing.Size(67, 13);
            this.fanSpeed.TabIndex = 4;
            this.fanSpeed.Text = "FAN SPEED";
            // 
            // getInfotimer
            // 
            this.getInfotimer.Interval = 1000;
            this.getInfotimer.Tick += new System.EventHandler(this.getInfotimer_Tick);
            // 
            // CaseFanControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 142);
            this.Controls.Add(this.fanSpeed);
            this.Controls.Add(this.gpuTemp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.silentButton);
            this.Name = "CaseFanControl";
            this.Text = "Case Fan Control";
            this.Load += new System.EventHandler(this.CaseFanControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button silentButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label gpuTemp;
        private System.Windows.Forms.Label fanSpeed;
        private System.Windows.Forms.Timer getInfotimer;
    }
}

