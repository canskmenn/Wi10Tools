using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wi10Tools
{
    public partial class stopupdate : Form
    {
        public stopupdate()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //Code that gets date and time in accordance with regedit
            string tarih = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string saat = dateTimePicker1.Value.ToString("HH:mm");
            string simdikitarih = DateTime.Now.ToString("yyyy-MM-dd");
            string simdikisaat = DateTime.Now.ToString("HH:mm");

            PowerShell ps = PowerShell.Create();
            //Code to add regedit update stop regs

            ps.AddScript("New-ItemProperty -Path HKLM:\\SOFTWARE\\Microsoft\\WindowsUpdate\\UX\\Settings -Name PauseFeatureUpdatesEndTime -Value " + tarih + "T" + saat + ":" + "17Z");
            ps.AddScript("New-ItemProperty -Path HKLM:\\SOFTWARE\\Microsoft\\WindowsUpdate\\UX\\Settings -Name PauseFeatureUpdatesStartTime -Value " + simdikitarih + "T" + simdikisaat + ":" + "17Z");
            ps.AddScript("New-ItemProperty -Path HKLM:\\SOFTWARE\\Microsoft\\WindowsUpdate\\UX\\Settings -Name PauseQualityUpdatesEndTime -Value " + tarih + "T" + saat + ":" + "17Z");
            ps.AddScript("New-ItemProperty -Path HKLM:\\SOFTWARE\\Microsoft\\WindowsUpdate\\UX\\Settings -Name PauseQualityUpdatesStartTime -Value " + simdikitarih + "T" + simdikisaat + ":" + "17Z");
            ps.AddScript("New-ItemProperty -Path HKLM:\\SOFTWARE\\Microsoft\\WindowsUpdate\\UX\\Settings -Name PauseUpdatesExpiryTime -Value " + tarih + "T" + saat + ":" + "17Z");
            ps.Invoke();
            foreach (var error in ps.Streams.Error)
                textBox1.Text = error.ToString();
            if (textBox1.Text == "")
            {
                textBox1.Text += "Command Successful";
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
