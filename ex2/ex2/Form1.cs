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
            writeMotorCommand(1600, 1);
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

        private void writeMotorCommand(ushort numTicks, int direction)
        {
            byte[] numberBytes = BitConverter.GetBytes(numTicks);
            byte[] bytesToSend = { 255, numberBytes[1], numberBytes[0], (byte) direction};
            debugTxtBox.AppendText(numberBytes[1].ToString() + "," + numberBytes[0].ToString());
            //debugTxtBox.AppendText(bytesToSend[0].ToString() + "," + bytesToSend[3].ToString());

            if (serialPort1.IsOpen)
            {
                debugTxtBox.AppendText(numberBytes.Length.ToString());
                serialPort1.Write(bytesToSend, 0, 4);
                debugTxtBox.AppendText("wrote something");
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBarTxtBox.Text = trackBar1.Value.ToString();

            if (trackBar1.Value < 0)
            {
                writeMotorCommand(Convert.ToUInt16(trackBar1.Value * -1), 2);
            }
            else {
                writeMotorCommand(Convert.ToUInt16(trackBar1.Value), 1);
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
    }
}
