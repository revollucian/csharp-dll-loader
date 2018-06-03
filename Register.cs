using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AesEncDec;
using System.Net;
using System.IO;
using System.Diagnostics;
using HWIDGbr;
using FTP;
using System.Security.Permissions;

namespace Zer0
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();


            string load = "V78CyDuxpecOJXWjqaD2HTXLjmevI89aQliXP9SYKpbDcsVm9NgkGLZWujG/cOCC";
            string kommando2 = AesCryp.Decrypt(load);

            string invite = invitetext.Text;
            string user = usernametext1.Text;
            string pass = passwordtext1.Text;



            string passencrypted;

            passencrypted = AesCryp.Encrypt(pass).ToString();
            string usercrypted = AesCryp.Encrypt(user);
            string invitecrypted = AesCryp.Encrypt(invite);



            string passdecrypted = AesCryp.Decrypt(passencrypted);
            string userdecrypted = AesCryp.Decrypt(usercrypted);


            string userftp = wc.DownloadString(kommando2 + "/ftpusr.txt");
            string passftp = wc.DownloadString(kommando2 + "/ftpass.txt");
            string host = wc.DownloadString(kommando2 + "/host.txt");
            string invitecode = wc.DownloadString(kommando2 + "/invites.txt");


            string invitecodeencrypted = AesCryp.Encrypt(invitecode);


            string userftpdecrypt = AesCryp.Decrypt(userftp);
            string passftpdecrypt = AesCryp.Decrypt(passftp);
            string hostdecrypt = AesCryp.Decrypt(host);



            //Some basic debug stuff 



            Process[] pname = Process.GetProcessesByName("wireshark");
            if (pname.Length > 0)
            {
                MessageBox.Show("Please close any malicious software");
                Application.Exit();
            }
            else
            {
                Process[] oof = Process.GetProcessesByName("ollydbg");
                if (pname.Length > 0)
                {
                    MessageBox.Show("Please close any malicious software");

                    Application.Exit();
                }
                else
                {
                    Process[] fiddlet = Process.GetProcessesByName("Fiddler");
                    if (pname.Length > 0)
                    {
                        MessageBox.Show("Please close any malicious software");
                        Application.Exit();
                    }
                    else
                    {
                        Process[] ndSpy = Process.GetProcessesByName("ndSpy");
                        if (pname.Length > 0)
                        {
                            MessageBox.Show("Please close any malicious software");
                            Application.Exit();
                        }
                        else
                        {

                            ftp ftpClient = new ftp(@hostdecrypt, userftpdecrypt , passftpdecrypt);

                            if (invite != invitecodeencrypted)
                            {
                                MessageBox.Show("Invalid invite code");

                            }
                            else
                            {

                                //Checking if the invite code is right , if it is we will create a temp file on the computer and tranfer it over to our server


                                if (invitetext.Text == invitecodeencrypted)
                                {
                                    FileIOPermission f = new FileIOPermission(PermissionState.None);
                                    f.AllLocalFiles = FileIOPermissionAccess.Write;

                                    f.Demand();

                                    string pathname = @"C:\\0\name.txt";
                                    string pathpass = @"C:\\0\pass.txt";
                                    string pathhwid = @"C:\\0\hwid.txt";

                                    string encryptedhwid = AesCryp.Encrypt(hwid.GetMachineGuid());
                                    File.Create(@pathname);
                                    File.Create(@pathpass);
                                    File.Create(@pathhwid);

                                    File.WriteAllText(@pathpass, passencrypted);
                                    File.WriteAllText(@pathname, user);
                                    File.WriteAllText(@pathhwid, encryptedhwid);

                                    System.Threading.Thread.Sleep(500);
                                    progressBar1.Value = 10;
                                    System.Threading.Thread.Sleep(1000);
                                    progressBar1.Value = 35;

                                    //transfering the files from our directory to our server

                                    ftpClient.upload(kommando2 + "users /" + user + " / " + user + ".txt" , @pathpass);
                                    ftpClient.upload(kommando2 + "users/" + user + " / " + "userhwid.txt", @pathhwid);
                                    ftpClient.upload(kommando2 + "users/" + user + " / " + "username.txt", @pathname);
                                    System.Threading.Thread.Sleep(1000);
                                    progressBar1.Value = 75;

                                    //then deleting the files because we dont need them xDD

                                    System.IO.File.Delete(@pathname);
                                    System.IO.File.Delete(@pathpass);
                                    System.IO.File.Delete(@pathhwid);
                                    progressBar1.Value = 100;
                                    MessageBox.Show("Welcome , ", usernametext1.Text);
                                    MessageBox.Show("Your account has been created , you can now log in with your chosen credentials");
                                    ftpClient = null;
                                    Login aaaaaa = new Login();
                                    this.Hide();
                                    aaaaaa.Show();
                                }
                            }
                        }
                    }
                }
            }
       }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
