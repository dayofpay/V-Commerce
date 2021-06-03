using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace V_Commerce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BackColor = System.Drawing.Color.Black; // <this instance>.<property>
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        public static string SetUsername = "";
        public static string GetUsername = "";
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

        private void button1_Click(object sender, EventArgs e) // В следващата версия
        {
            MessageBox.Show("SOON");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
