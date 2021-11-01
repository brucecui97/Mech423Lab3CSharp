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
            Byte upByte = (byte)(numTicks >> 8);
            Byte downByte = (byte)(numTicks & 255);
            debugTxtBox.AppendText(upByte.ToString() + "," + downByte.ToString());
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBarTxtBox.Text = trackBar1.Value.ToString();
            writeMotorCommand(Convert.ToUInt16(trackBar1.Value), 1);
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
    }
}
