using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        }

        private void writeMotorCommand(Decimal dutyCycle, int direction)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBarTxtBox.Text = trackBar1.Value.ToString();
        }
    }
}
