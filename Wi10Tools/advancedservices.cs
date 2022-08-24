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
    public partial class advancedservices : Form
    {
        public advancedservices()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        PowerShell ps = PowerShell.Create();
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
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Causes increased disk and cpu usage in the background to make searching faster. You can disable this service.");
        }

        private void linkLabel26_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Sysmain is a service that uses ram and cpu by optimizing the system in the background. You can disable this service");

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("TrkWks service maintains links between the NTFS file system files within the computer or across computers in the network domain. You can disable this service ");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("It allows you to use two user accounts. You can disable this service if there are no two users on your computer");

        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("If you do not use the Maps service, you can disable this service.");

        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("If you are not using an IPv6 internet connection, you can disable this service.");
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("monitors programs and detects problems, you can disable this service.");
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("If you are not in any workgroup, you can disable this service.");
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Diagnostic service service, you can disable this service.");
        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("It allows remote users to edit the registry on your computer. You can disable this service.");

        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Allows the transmission of error reports. You can disable this service.");

        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("If you are not using a scanner, you can disable this service.");
        }

        private void linkLabel14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("The WSCSVC (Windows Security Center) service monitors and reports security health settings on the computer. You can disable this service");
        }

        private void linkLabel17_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Copies user certificates and root certificates from smart cards into the current user's certificate store, detects when a smart card is inserted into a smart card reader, and, if needed, installs the smart card Plug and Play minidriver. You can disable this service");
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel16_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("The Windows biometric service gives client applications the ability to capture, compare, manipulate, and store biometric data without gaining direct access to any biometric hardware or samples. You can disable this service if you are not using facial recognition or fingerprinting.");

        }

        private void linkLabel15_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Provides the ability to share a cellular data connection with another device. You can disable this service");
        }

        private void linkLabel20_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Windows Update Service. You may experience problems if you disable this service. ");
        }

        private void linkLabel19_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Enables remediation and protection of Windows Update components. You may experience problems if you disable this service. ");

        }

        private void linkLabel18_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Manages access to smart cards read by your computer. You can disable this service");
        }

        private void linkLabel21_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Routes Wireless Application Protocol (WAP) Push messages received by the device and synchronizes Device Management sessions. You can disable this service");
        }

        private void linkLabel24_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("This service manages connected Xbox Accessories. You can disable this service");
        }

        private void linkLabel22_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Provides authentication and authorization services for interacting with Xbox Live. You may experience problems if you disable this service. ");
        }

        private void linkLabel23_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel25_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("This service syncs save data for Xbox Live save enabled games. If this service is stopped, game save data will not upload to or download from Xbox Live.");
        }

        private void linkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Enables you to send and receive faxes, utilizing fax resources available on your computer or on the network. You can disable this service");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Telemetry service. You should disable this service.");
        }

        private void wsearche_Click(object sender, EventArgs e)
        {
            enableservice("WSearch");
        }

        private void wsearch_Click(object sender, EventArgs e)
        {
            disableservice("WSearch");
        }

        private void button50_Click(object sender, EventArgs e)
        {
            disableservice("Sysmain");
        }

        private void button49_Click(object sender, EventArgs e)
        {
            enableservice("Sysmain");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            disableservice("TrkWks");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            enableservice("TrkWks");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            disableservice("seclogon");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            enableservice("seclogon");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            disableservice("MapsBroker");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            enableservice("MapsBroker");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            disableservice("iphlpsvc");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            enableservice("iphlpsvc");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            disableservice("PcaSvc");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            enableservice("PcaSvc");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            disableservice("lmhosts");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            enableservice("lmhosts");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            disableservice("DPS");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            enableservice("DPS");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            disableservice("RemoteRegistry");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            enableservice("RemoteRegistry");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            disableservice("WerSvc");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            enableservice("WerSvc");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            disableservice("StiSvc");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            enableservice("StiSvc");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            disableservice("wscsvc");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            enableservice("wscsvc");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            disableservice("CertPropSvc");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            enableservice("CertPropSvc");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            disableservice("WbioSrvc");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            enableservice("WbioSrvc");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            disableservice("icssvc");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            enableservice("icssvc");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            disableservice("wuauserv");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            enableservice("wuauserv");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            disableservice("WaaSMedicSvc");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            enableservice("WaaSMedicSvc");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            disableservice("SCardSvr");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            enableservice("SCardSvr");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            disableservice("dmwappushservice");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            enableservice("dmwappushservice");
        }

        private void button46_Click(object sender, EventArgs e)
        {
            disableservice("XboxGipSvc");
        }

        private void button45_Click(object sender, EventArgs e)
        {
            enableservice("XboxGipSvc");
        }

        private void button42_Click(object sender, EventArgs e)
        {
            disableservice("XblAuthManager");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            enableservice("XblAuthManager");
        }

        private void button48_Click(object sender, EventArgs e)
        {
            disableservice("XblGameSave");

        }

        private void button47_Click(object sender, EventArgs e)
        {
            enableservice("XblGameSave");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            disableservice("Fax");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            enableservice("Fax");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            disableservice("DiagTrack");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enableservice("DiagTrack");
        }
    }
}
