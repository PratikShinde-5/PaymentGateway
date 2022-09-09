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
    public partial class CardPayment : UserControl
    {
        public CardPayment()
        {
            InitializeComponent();
        }

        //Continue Button
        private void btn_Continue_Click(object sender, EventArgs e)
        {
            PayAmount pa = new PayAmount();
            pa.Show();
            this.Hide();

        }
    }
}
