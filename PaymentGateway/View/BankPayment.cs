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
    public partial class BankPayment : UserControl
    {
        public static long accnumber;
        public static string Ifsc;

        public BankPayment()
        {
            InitializeComponent();
        }
        //Continue Button
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_AccNum.Text) && !string.IsNullOrEmpty(txt_ConfirmAcc.Text) &&
               !string.IsNullOrEmpty(txt_ACName.Text) && !string.IsNullOrEmpty(txt_IFSC.Text))
                {
                    for(int i = 0; i < txt_ACName.Text.Length; i++)
                    {
                        if (char.IsLetter(txt_ACName.Text[i]))
                        {
                            txt_ACName.Text = txt_ACName.Text.ToLower();
                        }
                    }

                    if(txt_AccNum.Text == txt_ConfirmAcc.Text )
                    {
                        accnumber = Convert.ToInt64(txt_AccNum.Text);
                        Ifsc = txt_IFSC.Text;
                      

                        PayAmount pa = new PayAmount();
                        pa.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Account Number Cannot Match");
                    }
                }
               else
                {
                    MessageBox.Show("Field cannot empty");

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Details");
                txt_AccNum.Clear();
                txt_ACName.Clear();
                txt_ConfirmAcc.Clear();
                txt_IFSC.Clear();

            }
        }

        //Account Holder Name Validation
        private void txt_ACName_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_ACName.Text, "[^a-zA-Z]"))
            {
                MessageBox.Show("Please Enter only string.");
               
            }
        }
    }
}
