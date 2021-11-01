
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
            this.directionTxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 49);
            this.trackBar1.Maximum = 65535;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(480, 56);
            this.trackBar1.TabIndex = 0;
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
            this.debugTxtBox.Location = new System.Drawing.Point(40, 204);
            this.debugTxtBox.Name = "debugTxtBox";
            this.debugTxtBox.Size = new System.Drawing.Size(265, 22);
            this.debugTxtBox.TabIndex = 2;
            // 
            // openPort
            // 
            this.openPort.Location = new System.Drawing.Point(152, 302);
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
            this.comboBoxCOMPorts.Location = new System.Drawing.Point(25, 301);
            this.comboBoxCOMPorts.Name = "comboBoxCOMPorts";
            this.comboBoxCOMPorts.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCOMPorts.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(557, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "direction";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // directionTxtBox
            // 
            this.directionTxtBox.Location = new System.Drawing.Point(545, 49);
            this.directionTxtBox.Name = "directionTxtBox";
            this.directionTxtBox.Size = new System.Drawing.Size(100, 22);
            this.directionTxtBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.directionTxtBox);
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
        private System.Windows.Forms.TextBox directionTxtBox;
    }
}

