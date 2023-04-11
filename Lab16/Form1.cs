using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab16
{
    public partial class Form1 : Form
    {
        SerialPort comPort;
        private delegate void comDel(string newPoint);
        int currentPoint = 0;
        bool initiallized = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Filling combo box with ports
            cboPorts.Items.AddRange(SerialPort.GetPortNames());
            if (cboPorts.Items.Count > 0 ) cboPorts.SelectedIndex = 0;

            //Graph Setup
            while (chData.Series.Count > 0) chData.Series.RemoveAt(0);
            chData.Titles.Add("Arduino Acceleration Data via I2C");
            chData.ChartAreas[0].AxisY.Title = "Acceleration (G)";
            chData.ChartAreas[0].AxisY.Minimum = -10;
            chData.ChartAreas[0].AxisY.Maximum = 10;
            chData.Series.Add("Acceleration Data");
            chData.Series["Acceleration Data"].ChartType = SeriesChartType.Line;
            chData.Legends.Clear();
        }

        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            btnClosePort.Enabled = true;
            btnOpenPort.Enabled = false;

            //Serial Port Setup
            comPort = new SerialPort(cboPorts.Text, 9600, Parity.Odd, 7, StopBits.One);
            comPort.Handshake = Handshake.None;
            comPort.DataReceived += new SerialDataReceivedEventHandler(RecieveData);
            comPort.Open();
        }

        private void btnClosePort_Click(object sender, EventArgs e)
        {
            btnOpenPort.Enabled = true;
            btnClosePort.Enabled = false;
            comPort.Close();
            lblCurrentAcceleration.Text = "0.00";
            currentPoint = 0;
            initiallized = false;
        }

        private void btnClearChart_Click(object sender, EventArgs e)
        {
            chData.Series[0].Points.Clear();
        }

        private void RecieveData(object sender, SerialDataReceivedEventArgs e)
        {
            string newPoint = comPort.ReadLine();
            this.BeginInvoke(new comDel(ImplementData), new object[] { newPoint });
        }

        private void ImplementData(string newPoint)
        {
            lblCurrentAcceleration.Text = newPoint;

            if (initiallized)
            {
                if (currentPoint == 49)
                {
                    chData.Series[0].Points.RemoveAt(0);
                }
                else
                {
                    currentPoint++;
                }
                chData.Series[0].Points.AddY(Convert.ToDouble(newPoint));
            }
            initiallized = true;
        }
    }
}
