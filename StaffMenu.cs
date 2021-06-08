using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace V_Commerce
{
    public partial class StaffMenu : Form
    {
        public StaffMenu()
        {
            InitializeComponent(); // Добавянето на продукти ще бъде валидно във следващата версия на софтуера, текущата версия е само на UI Модула //
        }
        public static string DefaultInput = "";
        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            // Ще бъде продължено във следващата версия

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Remove("Липсва");
            checkedListBox1.Items.Add(textBox3.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                monthCalendar1.Visible = true;
                label5.Visible = true;
                textBox4.Visible = true;
                discountLabel.Text = "Отстъпката изтича на: ";
            }
            else
            {
                discountLabel.Text = "";
                monthCalendar1.Visible = false;
                label5.Visible = false;
                textBox4.Visible = false;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (btcBox.Checked == true)
            {
                if (Settings.GetBTCAddress == DefaultInput)
                {
                    MessageBox.Show("Моля, настройте вашият BTC Address от настройките първо !");
                }
                else if (Settings.GetBTCAddress != DefaultInput)
                {
                    MessageBox.Show("Успешно!");
                    AfterAuth.ProductList.Insert(MyCart.CartStatus,label2.Text);
                }
            }
            if (ethBox3.Checked == true)
            {
                if (Settings.GetETHAddress == DefaultInput)
                {
                    MessageBox.Show("Моля, настройте вашият ETH Address от настройките първо !");
                }
                else if (Settings.GetETHAddress != DefaultInput)
                {
                    MessageBox.Show("Успешно!");
                    AfterAuth.ProductList.Insert(MyCart.CartStatus, label2.Text);
                }
            }
            if (LTCBox.Checked == true)
            {
                if (Settings.GetLTCAddress == DefaultInput)
                {
                    MessageBox.Show("Моля, настройте вашият LTC Address от настройките първо !");
                }
                else if (Settings.GetLTCAddress != DefaultInput)
                {
                    MessageBox.Show("Успешно!");
                    AfterAuth.ProductList.Insert(MyCart.CartStatus, label2.Text);
                }
            }
            if (payPalBox.Checked == true)
            {
                if (Settings.GetPayPalAddress == DefaultInput)
                {
                    MessageBox.Show("Моля, настройте вашият PayPal Address от настройките първо !");
                }
                else if (Settings.GetPayPalAddress != DefaultInput)
                {
                    MessageBox.Show("Успешно!");
                    AfterAuth.ProductList.Insert(MyCart.CartStatus, label2.Text);
                }
            }
            if (payPalBox.Checked == false && LTCBox.Checked == false && ethBox3.Checked == false &&btcBox.Checked == false)
            {
                MessageBox.Show("Моля, изберете поне един платежен метод");
            }
        }

        private void payMentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В следващата версия ...");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Login S = new Login();
            S.Show();
        }
    }
}
