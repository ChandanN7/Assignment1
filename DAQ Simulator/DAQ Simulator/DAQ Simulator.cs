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
        string path = @"C:/temp/SampleLogging.txt";
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
                
                txtSamplingTime.Text = 6 + " Sec";
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
                txtSamplingTime.Text = 6 + " Sec";
                timer1.Enabled = true;
                timer1.Start();
                btnSampling.Enabled = false;
            }
        }
        private string SamplingData()
        {
           
           
            
            StringBuilder s = new StringBuilder();
            for (int i = 0; i < 7; i++)
            {
                Sensor sensor = new Sensor(counter);
                s.Append("Sensor Value +" + sensor.GetValue().ToString("F3"));
                s.Append(Environment.NewLine);
                s.Append("Sensor Id" + "=" + sensor.GetSensId());
                s.Append(Environment.NewLine);
                counter++;
            }
            
            return s.ToString();

        }

        private void btnLogging_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLoggingTime.Text))
            {
                txtLoggingTime.Text = 6 + " Sec";
                LogData(SamplingData());
            }
            else if (!string.IsNullOrEmpty(txtLoggingTime.Text))
            {

                LogData(SamplingData());
                txtSamplingTime.Text = 6 + " Sec";
            }
            MessageBox.Show(" Data logged in this path =" + path);
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
            MessageBox.Show("Please input text in all input fields (Sampling values)!!!).", "Input Information", System.Windows.Forms.MessageBoxButtons.OK);
        }
        int a = 6;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (a==0)
            {
                a = 6;
            }
            a--;
            txtSamplingTime.Text = a.ToString() + " Sec";
            if(a==0)
            {
                timer1.Stop();
                btnSampling.Enabled = true;
                
            }
            
        }
    }
}
