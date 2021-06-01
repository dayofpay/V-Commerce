using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace V_Commerce
{
    public partial class CartSystem : Form
    {
        private const string V = "Куриерска фирма: ЕКОНТ";

        public CartSystem()
        {
            InitializeComponent();
            label16.Text = "Обща стойност на поръчката: " + AfterAuth.totalcartprice + AfterAuth.currency;
        }
        public static int totalorders = 0;
        private void CartSystem_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox Cart = new ListBox();
            Cart.Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label8.Text = "Име:" + textBox1.Text;
            label9.Text = "Фамилия:" + textBox2.Text;
            label10.Text = "Тел Номер:" + textBox3.Text;
            if (checkBox1.Checked == true)
            {
                label11.Text = "Куриерска Фирма: Speedy";
            }
            if (checkBox2.Checked == true)
            {
                label11.Text = "Куриерска Фирма: Еконт";
            }
            if (checkBox1.Checked == true)
            {
                label12.Text = "Адрес на офис на Speedy:" + textBox4.Text;
            }
            if (checkBox2.Checked == true)
            {
                label12.Text = "Адрес на офис на Еконт:" + textBox4.Text;
            }
            if (checkBox4.Checked == true)
            {
                label13.Text = "Да бъде ли издадена фактура: ДА";
            }
            if (checkBox3.Checked == true)
            {
                label13.Text = "Да бъде ли издадена фактура: НЕ";
            }
            button2.Visible = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            totalorders++;
            if (totalorders < 5)
            {
                MessageBox.Show("Благодарим ви за поръчката, " + Form1.GetUsername + "\r\n Очаквано време, в което ще получите продукта: 3 ДНИ");
            }
            else
            {
                MessageBox.Show("Благодарим ви за поръчката, " + Form1.GetUsername + "\r\n Очаквано време, в което ще получите продукта: 7 ДНИ");
            }
        }
    }
}
