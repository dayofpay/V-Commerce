using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace V_Commerce
{
    public partial class AfterAuth : Form
    {

        public AfterAuth()
        {
            InitializeComponent();
            label1.Text = "Welcome, " + Form1.SetUsername;
            string GetCartInfo = ItemList.ToString();
            this.Controls.Add(listBox1);
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox Cart = new ListBox();
        }
        public static string currency = "ЛВ";
        public static int GetPrice = 0;
        public static int totalcartprice = 0;
        private List<string> ItemList = new List<string>();
        public static string GetCart = "";

        private void AfterAuth_Load(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Form1.SetUsername);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void countinue_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 14.90; i++)
            {
                label2.Text = "Количка общо лв: " + totalcartprice + currency;
                totalcartprice++;
            }
            listBox1.Items.Add("Лампа 142 СМ");
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10.00; i++)
            {
                label2.Text = "Количка общо лв: " + totalcartprice + currency;
                totalcartprice++;
            }
            listBox1.Items.Add("Лампа 14 СМ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (string s in ItemList)
            {
                var x = s.ToString();
                MessageBox.Show(x);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CartSystem cart = new CartSystem();
            cart.ShowDialog(this);
        }

    }
}
