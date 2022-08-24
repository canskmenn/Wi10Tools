using System;
using System.Collections;
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
    public partial class debloatselect : Form
    {
        public debloatselect()
        {
            InitializeComponent();
        }
       public ArrayList deletelist = new ArrayList();//a list for services to be deleted
        


        private void button1_Click(object sender, EventArgs e)
        {
            PowerShell ps = PowerShell.Create();
            ps.AddScript("get-appxpackage *getstarted* | remove-appxpackage");
            foreach (var val in deletelist)
            {
                ps.AddScript(val.ToString());

            }//Deletes all services in the "deletelist" list.

            ps.Invoke();
            foreach (var error in ps.Streams.Error)
                textBox1.Text = error.ToString();
            if (textBox1.Text == "")
            {
                textBox1.Text += "Command Successful";
            }
        }


        //add service in deletelist
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                deletelist.Add("Get-AppxPackage *3dbuilder* | Remove-AppxPackage");
                deletelist.Add("get-appxpackage *3d* | remove-appxpackage");
            }
            else
            {
                deletelist.Remove("Get-AppxPackage *3dbuilder* | Remove-AppxPackage");
                deletelist.Remove("get-appxpackage *3d* | remove-appxpackage");
            }



        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                deletelist.Add("get-appxpackage *bingfinance* | remove-appxpackage");
                deletelist.Add("get-appxpackage *bing* | remove-appxpackage");
            }
            else
            {
                deletelist.Remove("get-appxpackage *bingfinance* | remove-appxpackage");
                deletelist.Remove("get-appxpackage *bing* | remove-appxpackage");
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                deletelist.Add("get-appxpackage *feedback* | remove-appxpackage");
            }
            else
            {
                deletelist.Remove("get-appxpackage *feedback* | remove-appxpackage");
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                deletelist.Add("get-appxpackage *maps* | remove-appxpackage");
            }
            else
            {
                deletelist.Remove("get-appxpackage *maps* | remove-appxpackage");
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                deletelist.Add("get-appxpackage *people* | remove-appxpackage");
                deletelist.Add("get-appxpackage *messaging* | remove-appxpackage");
            }
            else
            {
                deletelist.Remove("get-appxpackage *people* | remove-appxpackage");
                deletelist.Remove("get - appxpackage * messaging * | remove - appxpackage");
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                deletelist.Add("get-appxpackage *wallet* | remove-appxpackage");
            }
            else
            {
                deletelist.Remove("get-appxpackage *wallet* | remove-appxpackage");
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                deletelist.Add("get-appxpackage *officehub* | remove-appxpackage");
                deletelist.Add("get-appxpackage -name “Microsoft.Office.Desktop” | Remove-AppxPackage");
            }
            else
            {
                deletelist.Remove("get-appxpackage *officehub* | remove-appxpackage");
                deletelist.Remove("get-appxpackage -name “Microsoft.Office.Desktop” | Remove-AppxPackage");
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                deletelist.Add("get-appxpackage *holographic* | remove-appxpackage");
            }
            else
            {
                deletelist.Remove("get-appxpackage *holographic* | remove-appxpackage");
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                deletelist.Add("get-appxpackage *alarms* | remove-appxpackage");
            }
            else
            {
                deletelist.Remove("get-appxpackage *alarms* | remove-appxpackage");
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                deletelist.Add("get-appxpackage *photos* | remove-appxpackage");
            }
            else
            {
                deletelist.Remove("get-appxpackage *photos* | remove-appxpackage");
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                deletelist.Add("get-appxpackage *calculator* | remove-appxpackage");
            }
            else
            {
                deletelist.Remove("get-appxpackage *calculator* | remove-appxpackage");
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                deletelist.Add("get-appxpackage *camera* | remove-appxpackage");
            }
            else
            {
                deletelist.Remove("get-appxpackage *camera* | remove-appxpackage");
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                deletelist.Add("get-appxpackage *solitaire* | remove-appxpackage");
            }
            else
            {
                deletelist.Remove("get-appxpackage *solitaire* | remove-appxpackage");
            }
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                deletelist.Add("get-appxpackage *connectivitystore* | remove-appxpackage");
            }
            else
            {
                deletelist.Remove("get-appxpackage *connectivitystore* | remove-appxpackage");
            }
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                deletelist.Add("get-appxpackage *windowsstore* | remove-appxpackage");
            }
            else
            {
                deletelist.Remove("get-appxpackage *windowsstore* | remove-appxpackage");
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                deletelist.Add("get-appxpackage *windowsphone* | remove-appxpackage");
                deletelist.Add("Get-appxpackage *phone* | Remove-AppxPackage");
            }
            else
            {
                deletelist.Remove("get-appxpackage *windowsphone* | remove-appxpackage");
                deletelist.Remove("get-appxpackage *phone* | Remove-AppxPackage");
            }
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                deletelist.Add("Get-AppxPackage -allusers Microsoft.549981C3F5F10 | Remove-AppxPackage");
            }
            else
            {
                deletelist.Remove("Get-AppxPackage -allusers Microsoft.549981C3F5F10 | Remove-AppxPackage");
            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                deletelist.Add("get-appxpackage *zune* | remove-appxpackage");
            }
            else
            {
                deletelist.Remove("get-appxpackage *zune* | remove-appxpackage");
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                deletelist.Add("get-appxpackage *soundrecorder* | remove-appxpackage");
            }
            else
            {
                deletelist.Remove("get-appxpackage *soundrecorder* | remove-appxpackage");
            }
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                deletelist.Add("get-appxpackage *communicationsapps* | remove-appxpackage");
            }
            else
            {
                deletelist.Remove("get-appxpackage *communicationsapps* | remove-appxpackage");
            }
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                deletelist.Add("Get-AppxPackage Microsoft.XboxApp | Remove-AppxPackage");
            }
            else
            {
                deletelist.Remove("Get-AppxPackage Microsoft.XboxApp | Remove-AppxPackage");
            }
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                deletelist.Add("get-appxpackage *sticky* | remove-appxpackage");
            }
            else
            {
                deletelist.Remove("get-appxpackage *sticky* | remove-appxpackage");
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                deletelist.Add("get-appxpackage *onenote* | remove-appxpackage");
            }
            else
            {
                deletelist.Remove("get-appxpackage *onenote* | remove-appxpackage");
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                deletelist.Add("get-appxpackage *skypeapp* | remove-appxpackage");
            }
            else
            {
                deletelist.Remove("get-appxpackage *skypeapp* | remove-appxpackage");
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                deletelist.Add("get-appxpackage Microsoft.MSPaint | Remove-AppxPackage");
            }
            else
            {
                deletelist.Remove("get-appxpackage Microsoft.MSPaint | Remove-AppxPackage");
            }
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                deletelist.Add("get-appxpackage Microsoft.MixedReality.Portal | Remove-AppxPackage");
            }
            else
            {
                deletelist.Remove("get-appxPackage Microsoft.MixedReality.Portal | Remove-AppxPackage");
            }
        }
    }
}
