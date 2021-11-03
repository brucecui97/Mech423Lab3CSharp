
namespace ex2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBarTxtBox = new System.Windows.Forms.TextBox();
            this.debugTxtBox = new System.Windows.Forms.TextBox();
            this.openPort = new System.Windows.Forms.Button();
            this.comboBoxCOMPorts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.shouldDoOneStepTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.oneStepCWButton = new System.Windows.Forms.Button();
            this.oneStepCCWButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(12, 49);
            this.trackBar1.Maximum = 225;
            this.trackBar1.Minimum = -225;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(480, 56);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 225;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBarTxtBox
            // 
            this.trackBarTxtBox.Location = new System.Drawing.Point(25, 158);
            this.trackBarTxtBox.Name = "trackBarTxtBox";
            this.trackBarTxtBox.Size = new System.Drawing.Size(100, 22);
            this.trackBarTxtBox.TabIndex = 1;
            // 
            // debugTxtBox
            // 
            this.debugTxtBox.Location = new System.Drawing.Point(25, 400);
            this.debugTxtBox.Name = "debugTxtBox";
            this.debugTxtBox.Size = new System.Drawing.Size(265, 22);
            this.debugTxtBox.TabIndex = 2;
            // 
            // openPort
            // 
            this.openPort.Location = new System.Drawing.Point(164, 207);
            this.openPort.Name = "openPort";
            this.openPort.Size = new System.Drawing.Size(75, 23);
            this.openPort.TabIndex = 3;
            this.openPort.Text = "openPort";
            this.openPort.UseVisualStyleBackColor = true;
            this.openPort.Click += new System.EventHandler(this.openPort_Click);
            // 
            // comboBoxCOMPorts
            // 
            this.comboBoxCOMPorts.FormattingEnabled = true;
            this.comboBoxCOMPorts.Location = new System.Drawing.Point(25, 207);
            this.comboBoxCOMPorts.Name = "comboBoxCOMPorts";
            this.comboBoxCOMPorts.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCOMPorts.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "ccw";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "cw";
            // 
            // shouldDoOneStepTxtBox
            // 
            this.shouldDoOneStepTxtBox.Location = new System.Drawing.Point(532, 49);
            this.shouldDoOneStepTxtBox.Name = "shouldDoOneStepTxtBox";
            this.shouldDoOneStepTxtBox.Size = new System.Drawing.Size(100, 22);
            this.shouldDoOneStepTxtBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(649, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "shouldDo1Step";
            // 
            // oneStepCWButton
            // 
            this.oneStepCWButton.Location = new System.Drawing.Point(382, 117);
            this.oneStepCWButton.Name = "oneStepCWButton";
            this.oneStepCWButton.Size = new System.Drawing.Size(110, 23);
            this.oneStepCWButton.TabIndex = 12;
            this.oneStepCWButton.Text = "stepCW";
            this.oneStepCWButton.UseVisualStyleBackColor = true;
            this.oneStepCWButton.Click += new System.EventHandler(this.oneStepCWButton_Click);
            // 
            // oneStepCCWButton
            // 
            this.oneStepCCWButton.Location = new System.Drawing.Point(25, 117);
            this.oneStepCCWButton.Name = "oneStepCCWButton";
            this.oneStepCCWButton.Size = new System.Drawing.Size(100, 23);
            this.oneStepCCWButton.TabIndex = 13;
            this.oneStepCCWButton.Text = "stepCCW";
            this.oneStepCCWButton.UseVisualStyleBackColor = true;
            this.oneStepCCWButton.Click += new System.EventHandler(this.oneStepCCWButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.oneStepCCWButton);
            this.Controls.Add(this.oneStepCWButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.shouldDoOneStepTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCOMPorts);
            this.Controls.Add(this.openPort);
            this.Controls.Add(this.debugTxtBox);
            this.Controls.Add(this.trackBarTxtBox);
            this.Controls.Add(this.trackBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox trackBarTxtBox;
        private System.Windows.Forms.TextBox debugTxtBox;
        private System.Windows.Forms.Button openPort;
        private System.Windows.Forms.ComboBox comboBoxCOMPorts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox shouldDoOneStepTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button oneStepCWButton;
        private System.Windows.Forms.Button oneStepCCWButton;
    }
}

