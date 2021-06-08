using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace V_Commerce
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }
        public static string GetBTCAddress = "";
        public static string GetETHAddress = "";
        public static string GetPayPalAddress = "";
        public static string GetLTCAddress = "";

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            StaffMenu S = new StaffMenu();
            S.Show();
        }

        private void bTCAdressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveButton.Visible = true;
            btcLabel.Visible = true;
            btcText.Visible = true;
            GetBTCAddress = btcText.Text;
        }

        private void payPalEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveButton.Visible = true;
            PaypalLabel.Visible = true;
            PayPalText.Visible = true;
            GetPayPalAddress = PayPalText.Text;
        }

        private void ethereumAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveButton.Visible = true;
            ethLabel.Visible = true;
            ethText.Visible = true;
            GetETHAddress = ethText.Text;
        }

        private void litecoinAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveButton.Visible = true;
            LtcLabel.Visible = true;
            LtcText.Visible = true;
            GetLTCAddress = LtcText.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetBTCAddress = btcText.Text;
            GetLTCAddress = LtcText.Text;
            GetPayPalAddress = PayPalText.Text;
            GetETHAddress = ethText.Text;
            SaveSuccess.Visible = true;
            SaveSuccess.Text = "Успешно запазване !"; // Активира се само при успешно запазване
        }

        private void PayPalText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
