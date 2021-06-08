using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
namespace V_Commerce
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
            BackColor = System.Drawing.Color.Black; // <this instance>.<property>
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        public static string latestversion = "4.0";
        public static string DataBaseAdr = "127.0.0.1";
        public static string DataBasePass = "1337";
        public static string DataBaseType = "MYSql";
        public static string DataBaseTable = "vcommerce";
        public static string DataBaseUser = "root";
        public static string SetUsername = "";
        public static string GetUsername = "";
        public static string GetAdmin = "";
        private void countinue_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Invalid Username ...");
            }
            else
            {
                GetUsername = textBox1.Text;
                SetUsername = textBox1.Text;
                this.Visible = false;
                AfterAuth afterAuth = new AfterAuth();
                afterAuth.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "admin")
            {
                MessageBox.Show("No Permission !");
            }
            else
            {
                GetAdmin = textBox1.Text;
                this.Visible = false;
                StaffMenu staffMenu = new StaffMenu();
                staffMenu.ShowDialog();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
            WebRequest request1 = WebRequest.Create("https://raw.githubusercontent.com/dayofpay/V-Commerce/main/latestversion");
            request1.Credentials = CredentialCache.DefaultCredentials;
            WebResponse response1 = request1.GetResponse();
            Stream dataStream1 = response1.GetResponseStream();
            StreamReader reader1 = new StreamReader(dataStream1);
            string responseFromServer1 = reader1.ReadToEnd();
            using (Stream dataStream = response1.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream1);
                string responseFromServer = reader.ReadToEnd();
                if (responseFromServer == "4.0")
                {
                    MessageBox.Show("Използвате последната версия !");
                }
                // В следващата версия
            }
        }
    }
}
