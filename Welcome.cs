using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;

namespace Zer0
{
    public partial class Welcome : Form
    {


        public Welcome()
        {

            InitializeComponent();

        
        }
        private void flowTheme1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuProgressBar1_progressChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
            System.Threading.Thread.Sleep(500);
            bunifuProgressBar1.Value = 5;
            Ping ping = new Ping();
            PingReply pingresult1 = ping.Send("google.com");
            System.Threading.Thread.Sleep(1000);
            if (pingresult1.Status.ToString() == "Success")
            {
                lblPing.BackColor = Color.Green;
                bunifuProgressBar1.Value = 25;
                System.Threading.Thread.Sleep(1000);
                bunifuProgressBar1.Value = 50;
            }
            else
            {
                lblPing.BackColor = Color.Red;
                MessageBox.Show("No internet connection");
            }

            PingReply pingresult2 = ping.Send("youtube.com");
            System.Threading.Thread.Sleep(1000);
            if (pingresult2.Status.ToString() == "Success")
            {
                label1.BackColor = Color.Green;
                bunifuProgressBar1.Value = 75;

                System.Threading.Thread.Sleep(1000);
                bunifuProgressBar1.Value = 100;
                Login niggForm = new Login();
                System.Threading.Thread.Sleep(500);
                this.Hide();
                niggForm.Show();

            }
            else
            {
                label1.BackColor = Color.Red;
            }

        }
    }
}
