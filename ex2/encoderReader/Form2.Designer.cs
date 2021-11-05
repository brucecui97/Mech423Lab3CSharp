﻿namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.itemsInQueueTxtBox = new System.Windows.Forms.TextBox();
            this.openPort = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tempStringLenTxtBox = new System.Windows.Forms.TextBox();
            this.serialBytesToReadTxtBox = new System.Windows.Forms.TextBox();
            this.serialDataStringLabel = new System.Windows.Forms.Label();
            this.serialDataStringTxtBox = new System.Windows.Forms.TextBox();
            this.comboBoxCOMPorts = new System.Windows.Forms.ComboBox();
            this.displayContentTimer = new System.Windows.Forms.Timer(this.components);
            this.debugTxtBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.orientationTxtBox = new System.Windows.Forms.TextBox();
            this.closePortButton = new System.Windows.Forms.Button();
            this.selectFileNameButton = new System.Windows.Forms.Button();
            this.selectFileNameTxtBox = new System.Windows.Forms.TextBox();
            this.ADiffMSBTxtBox = new System.Windows.Forms.TextBox();
            this.ADiffLSBTxtBox = new System.Windows.Forms.TextBox();
            this.BDiffMSBTxtBox = new System.Windows.Forms.TextBox();
            this.BDiffLSBTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.revPerSecTxtBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "serial bytes to read";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // itemsInQueueTxtBox
            // 
            this.itemsInQueueTxtBox.Location = new System.Drawing.Point(171, 109);
            this.itemsInQueueTxtBox.Name = "itemsInQueueTxtBox";
            this.itemsInQueueTxtBox.Size = new System.Drawing.Size(114, 22);
            this.itemsInQueueTxtBox.TabIndex = 1;
            // 
            // openPort
            // 
            this.openPort.Location = new System.Drawing.Point(171, 13);
            this.openPort.Name = "openPort";
            this.openPort.Size = new System.Drawing.Size(86, 25);
            this.openPort.TabIndex = 2;
            this.openPort.Text = "open port";
            this.openPort.UseVisualStyleBackColor = true;
            this.openPort.Click += new System.EventHandler(this.openPort_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "temp string length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "items in queue";
            // 
            // tempStringLenTxtBox
            // 
            this.tempStringLenTxtBox.Location = new System.Drawing.Point(171, 78);
            this.tempStringLenTxtBox.Name = "tempStringLenTxtBox";
            this.tempStringLenTxtBox.Size = new System.Drawing.Size(114, 22);
            this.tempStringLenTxtBox.TabIndex = 1;
            // 
            // serialBytesToReadTxtBox
            // 
            this.serialBytesToReadTxtBox.Location = new System.Drawing.Point(171, 47);
            this.serialBytesToReadTxtBox.Name = "serialBytesToReadTxtBox";
            this.serialBytesToReadTxtBox.Size = new System.Drawing.Size(114, 22);
            this.serialBytesToReadTxtBox.TabIndex = 1;
            // 
            // serialDataStringLabel
            // 
            this.serialDataStringLabel.AutoSize = true;
            this.serialDataStringLabel.Location = new System.Drawing.Point(26, 140);
            this.serialDataStringLabel.Name = "serialDataStringLabel";
            this.serialDataStringLabel.Size = new System.Drawing.Size(144, 17);
            this.serialDataStringLabel.TabIndex = 0;
            this.serialDataStringLabel.Text = "serialDataStringLabel";
            // 
            // serialDataStringTxtBox
            // 
            this.serialDataStringTxtBox.Location = new System.Drawing.Point(26, 159);
            this.serialDataStringTxtBox.Multiline = true;
            this.serialDataStringTxtBox.Name = "serialDataStringTxtBox";
            this.serialDataStringTxtBox.Size = new System.Drawing.Size(236, 200);
            this.serialDataStringTxtBox.TabIndex = 1;
            // 
            // comboBoxCOMPorts
            // 
            this.comboBoxCOMPorts.FormattingEnabled = true;
            this.comboBoxCOMPorts.Location = new System.Drawing.Point(26, 14);
            this.comboBoxCOMPorts.Name = "comboBoxCOMPorts";
            this.comboBoxCOMPorts.Size = new System.Drawing.Size(138, 24);
            this.comboBoxCOMPorts.TabIndex = 3;
            // 
            // displayContentTimer
            // 
            this.displayContentTimer.Tick += new System.EventHandler(this.displayContentTimer_tick);
            // 
            // debugTxtBox
            // 
            this.debugTxtBox.Location = new System.Drawing.Point(488, 76);
            this.debugTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.debugTxtBox.Multiline = true;
            this.debugTxtBox.Name = "debugTxtBox";
            this.debugTxtBox.Size = new System.Drawing.Size(422, 266);
            this.debugTxtBox.TabIndex = 4;
            this.debugTxtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // orientationTxtBox
            // 
            this.orientationTxtBox.Location = new System.Drawing.Point(511, 422);
            this.orientationTxtBox.Name = "orientationTxtBox";
            this.orientationTxtBox.Size = new System.Drawing.Size(114, 22);
            this.orientationTxtBox.TabIndex = 1;
            // 
            // closePortButton
            // 
            this.closePortButton.Location = new System.Drawing.Point(281, 14);
            this.closePortButton.Name = "closePortButton";
            this.closePortButton.Size = new System.Drawing.Size(86, 25);
            this.closePortButton.TabIndex = 2;
            this.closePortButton.Text = "close port";
            this.closePortButton.UseVisualStyleBackColor = true;
            this.closePortButton.Click += new System.EventHandler(this.closePortClick);
            // 
            // selectFileNameButton
            // 
            this.selectFileNameButton.Location = new System.Drawing.Point(488, 380);
            this.selectFileNameButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectFileNameButton.Name = "selectFileNameButton";
            this.selectFileNameButton.Size = new System.Drawing.Size(94, 23);
            this.selectFileNameButton.TabIndex = 5;
            this.selectFileNameButton.Text = "selectFileName";
            this.selectFileNameButton.UseVisualStyleBackColor = true;
            this.selectFileNameButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // selectFileNameTxtBox
            // 
            this.selectFileNameTxtBox.Location = new System.Drawing.Point(598, 382);
            this.selectFileNameTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectFileNameTxtBox.Name = "selectFileNameTxtBox";
            this.selectFileNameTxtBox.Size = new System.Drawing.Size(312, 22);
            this.selectFileNameTxtBox.TabIndex = 6;
            // 
            // ADiffMSBTxtBox
            // 
            this.ADiffMSBTxtBox.Location = new System.Drawing.Point(26, 365);
            this.ADiffMSBTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ADiffMSBTxtBox.Name = "ADiffMSBTxtBox";
            this.ADiffMSBTxtBox.Size = new System.Drawing.Size(53, 22);
            this.ADiffMSBTxtBox.TabIndex = 7;
            // 
            // ADiffLSBTxtBox
            // 
            this.ADiffLSBTxtBox.Location = new System.Drawing.Point(85, 365);
            this.ADiffLSBTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ADiffLSBTxtBox.Name = "ADiffLSBTxtBox";
            this.ADiffLSBTxtBox.Size = new System.Drawing.Size(47, 22);
            this.ADiffLSBTxtBox.TabIndex = 8;
            // 
            // BDiffMSBTxtBox
            // 
            this.BDiffMSBTxtBox.Location = new System.Drawing.Point(171, 364);
            this.BDiffMSBTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BDiffMSBTxtBox.Name = "BDiffMSBTxtBox";
            this.BDiffMSBTxtBox.Size = new System.Drawing.Size(50, 22);
            this.BDiffMSBTxtBox.TabIndex = 9;
            // 
            // BDiffLSBTxtBox
            // 
            this.BDiffLSBTxtBox.Location = new System.Drawing.Point(227, 364);
            this.BDiffLSBTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BDiffLSBTxtBox.Name = "BDiffLSBTxtBox";
            this.BDiffLSBTxtBox.Size = new System.Drawing.Size(50, 22);
            this.BDiffLSBTxtBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "AMSB";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "BLSB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "BMSB";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "ALSB";
            // 
            // revPerSecTxtBox
            // 
            this.revPerSecTxtBox.Location = new System.Drawing.Point(12, 423);
            this.revPerSecTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.revPerSecTxtBox.Name = "revPerSecTxtBox";
            this.revPerSecTxtBox.Size = new System.Drawing.Size(125, 22);
            this.revPerSecTxtBox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(160, 424);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "revPerSec";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Arrow;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(36, 464);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Color = System.Drawing.Color.Lime;
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.No;
            series1.SmartLabelStyle.CalloutLineAnchorCapStyle = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.None;
            series1.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.Transparent;
            series1.SmartLabelStyle.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.LabelCalloutStyle.None;
            series1.SmartLabelStyle.Enabled = false;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(860, 331);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 807);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.revPerSecTxtBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BDiffLSBTxtBox);
            this.Controls.Add(this.BDiffMSBTxtBox);
            this.Controls.Add(this.ADiffLSBTxtBox);
            this.Controls.Add(this.ADiffMSBTxtBox);
            this.Controls.Add(this.selectFileNameTxtBox);
            this.Controls.Add(this.selectFileNameButton);
            this.Controls.Add(this.closePortButton);
            this.Controls.Add(this.orientationTxtBox);
            this.Controls.Add(this.debugTxtBox);
            this.Controls.Add(this.comboBoxCOMPorts);
            this.Controls.Add(this.serialDataStringTxtBox);
            this.Controls.Add(this.serialDataStringLabel);
            this.Controls.Add(this.serialBytesToReadTxtBox);
            this.Controls.Add(this.tempStringLenTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.openPort);
            this.Controls.Add(this.itemsInQueueTxtBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.doWhenLoadForm);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox itemsInQueueTxtBox;
        private System.Windows.Forms.Button openPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tempStringLenTxtBox;
        private System.Windows.Forms.TextBox serialBytesToReadTxtBox;
        private System.Windows.Forms.Label serialDataStringLabel;
        private System.Windows.Forms.TextBox serialDataStringTxtBox;
        private System.Windows.Forms.ComboBox comboBoxCOMPorts;
        private System.Windows.Forms.Timer displayContentTimer;
        private System.Windows.Forms.TextBox debugTxtBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox orientationTxtBox;
        private System.Windows.Forms.Button closePortButton;
        private System.Windows.Forms.Button selectFileNameButton;
        private System.Windows.Forms.TextBox selectFileNameTxtBox;
        private System.Windows.Forms.TextBox ADiffMSBTxtBox;
        private System.Windows.Forms.TextBox ADiffLSBTxtBox;
        private System.Windows.Forms.TextBox BDiffMSBTxtBox;
        private System.Windows.Forms.TextBox BDiffLSBTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox revPerSecTxtBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

