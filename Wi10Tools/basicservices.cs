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
    public partial class basicservices : Form
    {
        public basicservices()
        {
            InitializeComponent();
        }
        public PowerShell ps = PowerShell.Create(); //public PowerShell 
        private void enableservice(string service)//a function for enable service
        {

            ps.AddScript("start-service -Name '" + service + "'");
            ps.AddScript("Set-Service -Name '" + service + "' -StartupType automatic");
            ps.Invoke();
            ps.Invoke();
            foreach (var error in ps.Streams.Error)
                textBox1.Text = error.ToString();
            if (textBox1.Text == "")
            {
                textBox1.Text += "Command Successful";
            }
        }
        private void disableservice(string service)//a function for disable service
        {

            ps.AddScript("stop-service -Name '" + service + "'");
            ps.AddScript("Set-Service -Name '" + service + "' -StartupType disabled"); 

            ps.Invoke();
            foreach (var error in ps.Streams.Error)
                textBox1.Text = error.ToString();
            if (textBox1.Text == "")
            {
                textBox1.Text += "Command Successful";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            //Remove bloat services
            disableservice("WSearch");
            disableservice("Sysmain");
            disableservice("PcaSvc");
            disableservice("DPS");
            disableservice("WerSvc");
            disableservice("CertPropSvc");
            disableservice("icssvc");
            disableservice("dmwappushservice");
            disableservice("DiagTrack");
            if (usexbox.Checked == false) //Checking checkboxes one by one
            {
                disableservice("XboxGipSvc");
                disableservice("XblAuthManager");
                disableservice("XblGameSave");
            }

            if (usescanner.Checked == false)
            {
                disableservice("StiSvc");
            }
            
            if (twoaccounts.Checked == false)
            {
                disableservice("seclogon");
            }
            if (localnetwork.Checked==false) {
                disableservice("TrkWks");
                disableservice("lmhosts");
            }
            if (remoteregistry.Checked == false)
            {
                disableservice("RemoteRegistry");
            }
            if (usefax.Checked == false)
            {
                disableservice("Fax");
            }
            if (windowsmap.Checked == false)
            {
                disableservice("MapsBroker");
            }
            if (sdcard.Checked == false)
            {
                disableservice("SCardSvr");
            }
            if (fingerprint.Checked == false)
            {
                disableservice("WbioSrvc");
            }
            if (ipv6.Checked == false)
            {
                disableservice("iphlpsvc");
            }

        }

        private void basicservices_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            advancedservices advancedservicess = new advancedservices();
            advancedservicess.Show();//Show Advance Screen
        }

        private void security_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
