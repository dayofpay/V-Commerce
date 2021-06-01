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
        public MyCart() // В следващата версия
        {
            var convert = AfterAuth.totalcartprice.ToString();
            InitializeComponent();
            int GetCartPrice = AfterAuth.totalcartprice;
            string[] row = { AfterAuth.ProductOne, convert, AfterAuth.OrderStatus };
            var listViewItem1 = new ListViewItem(row);
            listView1.Items.Add(listViewItem1);
            listView1.GridLines = true;
            listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
