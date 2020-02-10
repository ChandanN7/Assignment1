using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAQ_Simulator
{
    public partial class DAQ_Simulator : Form
    {

        public int counter = 0;
        string path = @"C:/temp//SampleLogging.txt";
        public DAQ_Simulator()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSampling_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtSamplingTime.Text))
            {
                
                txtSamplingTime.Text = 4.3 + " Sec";
                txtSensorValues.Text = "";
                txtSensorValues.Text = SamplingData();
                timer1.Enabled = true;
                timer1.Start();
                btnSampling.Enabled = false;
            }
            else if (!string.IsNullOrEmpty(txtSamplingTime.Text))
            {
                txtSensorValues.Text = string.Empty;
                txtSensorValues.Text = "";
                txtSensorValues.Text = SamplingData();
                txtSamplingTime.Text = 4.3 + " Sec";
                timer1.Enabled = true;
                timer1.Start();
                btnSampling.Enabled = false;
            }
        }
        private string SamplingData()
        {
           
           
            
            StringBuilder s = new StringBuilder();
            for (int i = 0; i < 12; i++)
            {
                Sensor sensor = new Sensor(counter);
                s.Append("Sensor Value +" + sensor.GetValue().ToString("F3"));
                s.Append(Environment.NewLine);
                s.Append("Sensor Id" + "=" + sensor.GetSensId());
                s.Append(Environment.NewLine);
                s.Append("Voltage" + "=" + sensor.GetVoltage());
                s.Append(Environment.NewLine);
                counter++;
            }
            
            return s.ToString();

        }

        private void btnLogging_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLoggingTime.Text))
            {
                txtLoggingTime.Text = 4.4 + " Sec";
                LogData(SamplingData());
                timer2.Enabled = true;
                timer2.Start();
                btnLogging.Enabled = false;
            }
            else if (!string.IsNullOrEmpty(txtLoggingTime.Text))
            {

                LogData(SamplingData());
                txtSamplingTime.Text = 4.4 + " Sec";
                timer2.Enabled = true;
                timer2.Start();
                btnLogging.Enabled = false;
            }
            MessageBox.Show(" Data has been logged into a file in the :" + path);
        }
        private void LogData(string text)
        {
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(text);

                }
            }
            else
            {
                using (StreamWriter fs = File.AppendText(path))
                {
                    fs.WriteLine(text);
                }
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CLick on the Sampling button to get sensor values, click on logging button to log the values to text, make sure to create a 'temp' folder in 'C:' drive!!!).", "Input Information", System.Windows.Forms.MessageBoxButtons.OK);
        }
        double a = 4.4;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (a==0)
            {
                a = 4.4;
            }
            a=a-.1;
            txtSamplingTime.Text = Math.Round(a, 1) + " Sec";
            if(a<0)
            {
                timer1.Stop();
                btnSampling.Enabled = true;
                a = 0;
            }
            
        }

        private void txtSensorValues_TextChanged(object sender, EventArgs e)
        {
            txtSensorValues.ScrollBars = ScrollBars.Vertical;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void txtSamplingTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (a == 0)
            {
                a = 6;
            }
            a--;
            txtLoggingTime.Text = a.ToString() + " Sec";
            if (a == 0)
            {
                timer2.Stop();
                btnLogging.Enabled = true;

            }

        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
