using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Security.Cryptography;
using System.IO;
using System.Net;

using Zer0.Properties;

using AesEncDec;
using HWIDGbr;


namespace Zer0
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            usernametext.Text = Settings.Default.username.ToString();

            passwordtext.Text = Settings.Default.password.ToString();

            checkBox1.Checked = Settings.Default.checkbox;



        }
        private void flowTheme1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username;
            username = usernametext.Text;
            string password;
            password = passwordtext.Text;
            string dir = usernametext.Text;
            string dirpass = passwordtext.Text;
            string encryptedhwid = AesCryp.Encrypt(hwid.GetMachineGuid());
            string decrypteddhwid = AesCryp.Decrypt(encryptedhwid);
            TimeZone localZone = TimeZone.CurrentTimeZone;
            DateTime currentDate = DateTime.Now;

            string dirpassencrypted = AesCryp.Encrypt(dirpass);
            string direncrypted = AesCryp.Encrypt(dir);


            //this is the encrypted website link , replace it with your own directory

            string load = "V78CyDuxpecOJXWjqaD2HTXLjmevI89aQliXP9SYKpbDcsVm9NgkGLZWujG/cOCC";




            string kommando2 = AesCryp.Decrypt(load);


            WebClient wc = new WebClient();
            string hostName = Dns.GetHostName();
            string encryptedhost = AesCryp.Encrypt(hostName);



            var srpnume = wc.DownloadString(kommando2 + "users/" + username + " / " + "username.txt");             //just reads the name/pass/hwid
            var srparola = wc.DownloadString(kommando2 + "users/" + username + " / " + username + ".txt");             //also you might want to change the name of the text files you put stuff in
            var srhwid = wc.DownloadString(kommando2 + "users/" + username + " / " + "userhwid.txt");             


            //decrypting the info we got


            string decusr = AesCryp.Decrypt(srpnume);
            string decpass = AesCryp.Decrypt(srparola);
            string hwidpass = AesCryp.Decrypt(srhwid);

            string error = "(404) Not Found.";

            if (decrypteddhwid != hwidpass)
            {
                MessageBox.Show("Invalid HWID :(");
            }
            else
            {

                //checking if the input info is fine 

                if (decusr == usernametext.Text && decpass == passwordtext.Text && decrypteddhwid == hwidpass )
                {
                    MessageBox.Show("Welcome," + decusr );
                }
                else
                {
                    MessageBox.Show("Wrong username or password , please check your credentials");
                }

                //error messages

                if (srpnume == error && srparola == error && srhwid == error)
                {
                    MessageBox.Show("User does not exist");

                }
                if (srpnume == error && srparola == error)
                {
                    MessageBox.Show("User does not exist");

                }
                if (srpnume == error )
                {
                    MessageBox.Show("User does not exist");

                }
                if (usernametext.Text.Length > 0 && passwordtext.Text.Length > 0)
                    button1.Enabled = true;
                else
                    button1.Enabled = false;

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            troubleshoot xyz = new troubleshoot();
            this.Hide();
            xyz.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Login_Close(object sender, EventArgs e)
        {
            Settings.Default.checkbox = checkBox1.Checked;
            Settings.Default.username = usernametext.Text;
            Settings.Default.password = passwordtext.Text;
            Settings.Default.Save();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            Settings.Default.checkbox = checkBox1.Checked;
            Settings.Default.username = usernametext.Text;
            Settings.Default.password = passwordtext.Text;
            Settings.Default.Save();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Register aaa = new Register();
            this.Close();
            aaa.Show();
        }
    }
}

