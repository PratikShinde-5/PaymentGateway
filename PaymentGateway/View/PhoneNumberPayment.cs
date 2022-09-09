using PaymentGateway.Repo;
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

    public partial class PhoneNumberPayment : UserControl
    {
        MongoRepo db;

        public static long userNumber;
       
        public PhoneNumberPayment()
        {
            db = new MongoRepo();
            InitializeComponent();
        }

        //Continue Button
        private void btn_PContinue_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_PhoneNumber.Text))
                {
                    long number = Convert.ToInt64(txt_PhoneNumber.Text);

                    int num = db.Search_Number(number);
                    if (num != 0)
                    {
                        userNumber = number;
                        PayAmount pa = new PayAmount();
                        pa.Show();
                        this.Hide();
                    }
                    else
                    {
                   
                        MessageBox.Show("Number Not Present in the List");
                        txt_PhoneNumber.Clear();
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Try Again");
                txt_PhoneNumber.Clear();
            }
            
        }

       
    }
}
