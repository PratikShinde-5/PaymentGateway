using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentGateway
{
    public partial class PaymentTypes : Form
    {
        public PaymentTypes()
        {
            InitializeComponent();
        }

        //Button Phone Number
        private void iconButton2_Click(object sender, EventArgs e)
        {
            panelDesktop.Controls.Clear();
            panelDesktop.Controls.Add(new PhoneNumberPayment());
        }

        //Button Bank
        private void iconButton1_Click(object sender, EventArgs e)
        {
            panelDesktop.Controls.Clear();
            panelDesktop.Controls.Add(new BankPayment());
        }

        private void btn_CardPayment_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comming Soon");
            //panelDesktop.Controls.Clear();
            //panelDesktop.Controls.Add(new CardPayment());
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            WelComeForm fc = new WelComeForm();
            fc.Show();
            this.Hide();
        }
    }
}
