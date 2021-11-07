using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private static long PLOT_TIME_RANGE_MILLISECONDS = 10000;
        SerialPort serialPort1 = new SerialPort("portNameNotSet", 9600, Parity.None, 8, StopBits.One);
        ConcurrentQueue<Int32> dataQueue = new ConcurrentQueue<Int32>();
        string serialDataString = "";
        EncoderData encoderData = new EncoderData();

        EncoderDataCategory currentEncoderValue = EncoderDataCategory.Unknown;
        Double processedSpeedHz = double.NaN;
        long startTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
        double netEncoderStepsTakenSinceStart = 0;

        public Form1()
        {
            InitializeComponent();
            initPlot();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }

        private void initPlot()
        {
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 10000;
            chart1.ChartAreas[0].AxisX.Title = "time since program start (millisecond)";
            chart1.ChartAreas[0].AxisY.Title = "motor speed (rev/s)";
            chart1.ChartAreas[0].AxisX.Maximum = 10000;
            chart1.Series[0].IsValueShownAsLabel = false;
            chart1.Series[0].LegendText = "motor revsPerSec";
            chart1.Series[0].ChartType = SeriesChartType.Point;
            chart1.Series[0].IsValueShownAsLabel = true;

            //so the label of the value of the point is not shown
            chart1.Series[0].LabelForeColor = Color.Transparent;

            chart2.ChartAreas[0].AxisX.Minimum = 0;
            chart2.ChartAreas[0].AxisX.Maximum = 10000;
            chart2.ChartAreas[0].AxisX.Title = "time since program start (millisecond)";
            chart2.ChartAreas[0].AxisY.Title = "motor position (encoder counts)";
            chart2.ChartAreas[0].AxisX.Maximum = 10000;
            chart2.Series[0].IsValueShownAsLabel = false;
            chart2.Series[0].LegendText = "motor positiion (encoder count)";
            chart2.Series[0].ChartType = SeriesChartType.Point;
            chart2.Series[0].IsValueShownAsLabel = true;

            //so the label of the value of the point is not shown
            chart2.Series[0].LabelForeColor = Color.Transparent;
        }

        private void DataReceivedHandler(
                    object sender,
                    SerialDataReceivedEventArgs e)
        {
            int bytesToRead = serialPort1.BytesToRead;
            while (bytesToRead != 0)
            {
                ThreadHelperClass.SetText(this, serialBytesToReadTxtBox, serialPort1.BytesToRead.ToString());
                int newByte = serialPort1.ReadByte();
                dataQueue.Enqueue(newByte);
                processEncoderStream(newByte);

                serialDataString = serialDataString + "," + newByte.ToString();
                bytesToRead = serialPort1.BytesToRead;
            }

        }
        private void doWhenLoadForm(object sender, EventArgs e)
        {
            comboBoxCOMPorts.Items.Clear();
            comboBoxCOMPorts.Items.AddRange(SerialPort.GetPortNames());
            if (comboBoxCOMPorts.Items.Count == 0)
                comboBoxCOMPorts.Text = "No COM ports!";
            else
                comboBoxCOMPorts.SelectedIndex = 0;
        }



        private void openPort_Click(object sender, EventArgs e)
        {
            debugTxtBox.AppendText("clicked open port");
            serialPort1.PortName = comboBoxCOMPorts.Text;
            serialPort1.Open();
            displayContentTimer.Enabled = true;
            debugTxtBox.AppendText("enabled timer");
        }

        private void displayContentTimer_tick(object sender, EventArgs e)
        {
            debugTxtBox.AppendText("triggered Timer event");
            if (serialPort1.IsOpen)
            {
                serialBytesToReadTxtBox.Text = serialPort1.BytesToRead.ToString();
                itemsInQueueTxtBox.Text = dataQueue.Count.ToString();
                while (!dataQueue.IsEmpty)
                {
                    if (dataQueue.TryDequeue(out int dequeueResult))
                    {
                        serialDataStringTxtBox.AppendText(dequeueResult.ToString() + ",");
                    }
                }
                tempStringLenTxtBox.Text = serialDataString.Length.ToString();
                serialDataString = "";
            }

            if (processedSpeedHz != double.NaN)
            {
                long timeStamp = -startTime + DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
                chart1.Series[0].Points.AddXY(timeStamp, processedSpeedHz);
                chart1.ChartAreas[0].AxisX.Minimum = timeStamp - PLOT_TIME_RANGE_MILLISECONDS/2;
                chart1.ChartAreas[0].AxisX.Maximum = timeStamp + PLOT_TIME_RANGE_MILLISECONDS;

                chart2.Series[0].Points.AddXY(timeStamp, netEncoderStepsTakenSinceStart);
                chart2.ChartAreas[0].AxisX.Minimum = timeStamp - PLOT_TIME_RANGE_MILLISECONDS / 2;
                chart2.ChartAreas[0].AxisX.Maximum = timeStamp + PLOT_TIME_RANGE_MILLISECONDS;
            }
            netStepCountTxtBox.Text = netEncoderStepsTakenSinceStart.ToString();
        }

        private void processEncoderStream(int newByte)
        {
            if (currentEncoderValue != EncoderDataCategory.Unknown && newByte==255) {
                newByte = 0;
            }

            if (currentEncoderValue == EncoderDataCategory.Unknown)
            {
                if (newByte == 255)
                {
                    currentEncoderValue = EncoderDataCategory.ChannelAMSB;
                }
            }
            else if (currentEncoderValue == EncoderDataCategory.ChannelAMSB)
            {
                encoderData.channelADiffMSB = newByte;

                ThreadHelperClass.SetText(this, ADiffMSBTxtBox, encoderData.channelADiffMSB.ToString());
                currentEncoderValue = EncoderDataCategory.ChannelALSB;
            }

            else if (currentEncoderValue == EncoderDataCategory.ChannelALSB)
            {
                encoderData.channelADiffLSB = newByte;
                ThreadHelperClass.SetText(this, ADiffLSBTxtBox, encoderData.channelADiffLSB.ToString());
                currentEncoderValue = EncoderDataCategory.ChannelBMSB;
            }

            else if (currentEncoderValue == EncoderDataCategory.ChannelBMSB)
            {
                encoderData.channelBDiffMSB = newByte;
                ThreadHelperClass.SetText(this, BDiffMSBTxtBox, encoderData.channelBDiffMSB.ToString());
                currentEncoderValue = EncoderDataCategory.ChannelBLSB;
            }


            else if (currentEncoderValue == EncoderDataCategory.ChannelBLSB) {
                encoderData.channelBDiffLSB = newByte;
                ThreadHelperClass.SetText(this, BDiffLSBTxtBox, encoderData.channelBDiffLSB.ToString());
                currentEncoderValue = EncoderDataCategory.Unknown;
                ThreadHelperClass.SetText(this, revPerSecTxtBox, EncoderDataHandler.calculateRotationalSpeedHz(encoderData).ToString());

                processedSpeedHz = EncoderDataHandler.calculateRotationalSpeedHz(encoderData);
                netEncoderStepsTakenSinceStart = netEncoderStepsTakenSinceStart + EncoderDataHandler.calculateNetStepChange(encoderData);
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
        }

        private void closePortClick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectFileNameTxtBox.Text = saveFileDialog1.FileName;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
