using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxCOMPorts.Items.Clear();
            comboBoxCOMPorts.Items.AddRange(SerialPort.GetPortNames());
            if (comboBoxCOMPorts.Items.Count == 0)
                comboBoxCOMPorts.Text = "No COM ports!";
            else
                comboBoxCOMPorts.SelectedIndex = 0;
        }

        private void writeMotorCommand(byte speed, byte direction, byte shoulDoOneStep)
        {
            byte[] bytesToSend = { 255, speed, direction, shoulDoOneStep };
            debugTxtBox.AppendText(bytesToSend[0].ToString() + "," + bytesToSend[1].ToString());
            //debugTxtBox.AppendText(bytesToSend[0].ToString() + "," + bytesToSend[3].ToString());

            if (serialPort1.IsOpen)
            {
                serialPort1.Write(bytesToSend, 0, 4);
                debugTxtBox.AppendText("wrote something");
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBarTxtBox.Text = trackBar1.Value.ToString();

            if (serialPort1.IsOpen)
            {
                if (trackBar1.Value < 0)
                {
                    writeMotorCommand(Convert.ToByte(trackBar1.Value * -1), 2, Convert.ToByte(Convert.ToInt32(shouldDoOneStepTxtBox.Text)));
                }
                else
                {
                    writeMotorCommand(Convert.ToByte(trackBar1.Value), 1, Convert.ToByte(Convert.ToInt32(shouldDoOneStepTxtBox.Text)));
                }
            }
        }

        private void openPort_Click(object sender, EventArgs e)
        {
            debugTxtBox.AppendText("clicked open port");
            serialPort1.PortName = comboBoxCOMPorts.Text;
            serialPort1.Open();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void oneStepCCWButton_Click(object sender, EventArgs e)
        {
            if (shouldDoOneStepTxtBox.Text == "1") {
                writeMotorCommand(0, 2, 1);
            }
        }

        private void oneStepCWButton_Click(object sender, EventArgs e)
        {
            if (shouldDoOneStepTxtBox.Text == "1")
            {
                writeMotorCommand(0, 1, 1);
            }
        }
    }
}
