using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wi10Tools
{
    public partial class mainmenu : Form
    {
        public mainmenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            debloatselect debloatselectt = new debloatselect();
            debloatselectt.Show();//open Debloat Form
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PowerShell ps = PowerShell.Create();  //PoweShell Console
            ps.AddScript("Get-AppxPackage *phone* | Remove-AppxPackage");
            ps.AddScript("Get-AppxPackage *3dbuilder* | Remove-AppxPackage");
            ps.AddScript("get-appxpackage *3d* | remove-appxpackage");
            ps.AddScript("get-appxpackage *getstarted* | remove-appxpackage");
            ps.AddScript("get-appxpackage *bingfinance* | remove-appxpackage");
            ps.AddScript("get-appxpackage *bing* | remove-appxpackage");
            ps.AddScript("get-appxpackage *feedback* | remove-appxpackage");
            ps.AddScript("get-appxpackage *maps* | remove-appxpackage");
            ps.AddScript("get-appxpackage *people* | remove-appxpackage");
            ps.AddScript("get-appxpackage *messaging* | remove-appxpackage");
            ps.AddScript("get-appxpackage *wallet* | remove-appxpackage");
            ps.AddScript("get-appxpackage *officehub* | remove-appxpackage");
            ps.AddScript("get-appxpackage *onenote* | remove-appxpackage");
            ps.AddScript("get-appxpackage *mspaint* | remove-appxpackage");
            ps.AddScript("get-appxpackage *skypeapp* | remove-appxpackage");
            ps.AddScript("get-appxpackage *commsphone* | remove-appxpackage");
            ps.AddScript("get-appxpackage *holographic* | remove-appxpackage");
            ps.AddScript("get-appxpackage *alarms* | remove-appxpackage");
            ps.AddScript("get-appxpackage *photos* | remove-appxpackage");
            ps.AddScript("get-appxpackage *calculator* | remove-appxpackage");
            ps.AddScript("get-appxpackage *camera* | remove-appxpackage");
            ps.AddScript("get-appxpackage *solitaire* | remove-appxpackage");
            ps.AddScript("get-appxpackage *connectivitystore* | remove-appxpackage");
            ps.AddScript("get-appxpackage *zune* | remove-appxpackage");
            ps.AddScript("get-appxpackage *soundrecorder* | remove-appxpackage");
            ps.AddScript("get-appxpackage *communicationsapps* | remove-appxpackage");
            ps.AddScript("get-appxpackage *windowsphone* | remove-appxpackage");
            ps.AddScript("Get-AppxPackage Microsoft.XboxApp | Remove-AppxPackage");
            ps.AddScript("get-appxpackage *windowsstore* | remove-appxpackage");
            ps.AddScript("get-appxpackage *appinstaller* | remove-appxpackage");
            ps.AddScript("get-appxpackage *sticky* | remove-appxpackage");
            ps.AddScript("Get-AppxPackage -allusers Microsoft.549981C3F5F10 | Remove-AppxPackage");
            ps.Invoke();
            foreach (var error in ps.Streams.Error)
                textBox1.Text = error.ToString();
            if (textBox1.Text == "")
            {
                textBox1.Text += "Command Successful";
            }
        }//PowerShell will print the error logs to the screen.


        private void button4_Click(object sender, EventArgs e)
        {
            stopupdate form2 = new stopupdate();
            form2.Show();//Open StopUpdate Form
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }


        private void button7_Click(object sender, EventArgs e)
        {
            basicservices basic = new basicservices();
            basic.Show();//open services-1 form
        }
    }
}
