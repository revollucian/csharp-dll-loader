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

using AesEncDec;
using HWIDGbr;


namespace Zer0
{
    public partial class troubleshoot : Form
    {
        public troubleshoot()
        {
            InitializeComponent();
        }

        private void troubleshoot_Load(object sender, EventArgs e)
        {

            // get the hwid from our class and display it
            string hwid1;
            hwid1 = hwid.GetMachineGuid();          
            hwidtext.Text = AesCryp.Encrypt(hwid1);
            string hostName = Dns.GetHostName(); // Retrive the Name of HOST  
            // Get the IP  
            string myIP = Dns.GetHostEntry(hostName).AddressList[0].ToString();
            textBox1.Text = myIP;
            textBox2.Text = hostName;

        }

        private void hwidtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login xyz = new Login();
            xyz.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
