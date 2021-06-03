using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace V_Commerce
{
    public partial class MyCart : Form
    {

        public MyCart()
        {
            InitializeComponent();
            label2.Text = "Обща стойност на поръчката";
            listBox3.Items.Add(AfterAuth.totalcartprice + "ЛВ");
            this.Controls.Add(listBox1);
            this.Controls.Add(listBox2);
            this.Controls.Add(listBox3);
            foreach (string Items in AfterAuth.ItemList)
            {
                listBox1.Items.Add(Items);
                Orders.Add(Items);
                if (Items == "Лампа 142 СМ")
                {
                    listBox2.Items.Add("14.90 ЛВ");
                }
                if (Items == "Лампа 14 СМ")
                {
                    listBox2.Items.Add("10 ЛВ");
                }
                if (AfterAuth.totalcartprice == 0)
                {
                    listBox1.Items.Clear();
                    listBox2.Items.Clear();
                    listBox3.Items.Clear();
                }
            }
        }
        public static List<string> Orders = new List<string>();
        public static int CartStatus = 0;
        public static string GetItems = "";

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MyCart_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
