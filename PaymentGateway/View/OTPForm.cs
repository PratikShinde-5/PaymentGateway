using PaymentGateway.Model;
using PaymentGateway.Repo;
using PaymentGateway.View;
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
    public partial class OTPForm : Form
    {
        MongoRepo db ;
        Transaction t1 = new Transaction();
        public OTPForm()
        {
            db = new MongoRepo();
            InitializeComponent();
        }

        //Confirm Button
        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_OTP.Text))
                {
                    long number = Convert.ToInt64(UserLogin.Phone_Number);
                    int checkotp = Convert.ToInt32(txt_OTP.Text);
                    var result = db.ConfirmOTP(number,checkotp);
                    double amount = (double)result["Amount"];
                    long number2 = PhoneNumberPayment.userNumber;
                    double mm = PayAmount.amt;
                    if (number != 0 && number2!=0)
                    {
                        if (checkotp == result["Bank_OTP"] && number == result["Phone_Number"])
                        {

                            int count = db.Pay_Amount(mm, number, number2);
                            if (count > 0)
                            {
                                string str = "Payment Success";
                                Transaction(str);
                                MessageBox.Show("Payment Success");
                                WelComeForm ec = new WelComeForm();
                                ec.Show();
                                this.Hide();


                            }
                            else
                            {
                                string str = "Payment Failed";
                                Transaction(str);
                                MessageBox.Show("Payment Failed");
                                PaymentTypes pt = new PaymentTypes();
                                pt.Show();
                                this.Hide();


                            }
                        }


                    }
                    else
                    {
                        //Bank Payment
                        long acc = BankPayment.accnumber;
                        string ifsc = BankPayment.Ifsc;

                        if (checkotp == result["Bank_OTP"]  && number == result["Phone_Number"])
                        {

                            long phonenum = UserLogin.Phone_Number;
                            int count = db.Pay_AmountInBank(mm, acc, ifsc, phonenum);
                            if (count > 0)
                            {
                                string str = "Payment Success";
                                TransactionB(str);
                                MessageBox.Show("Payment Success");
                                WelComeForm ec = new WelComeForm();
                                ec.Show();
                                this.Hide();


                            }
                            else
                            {
                                string str = "Payment Failed";
                                TransactionB(str);
                                MessageBox.Show("Payment Failed");
                                PaymentTypes pt = new PaymentTypes();
                                pt.Show();
                                this.Hide();


                            }

                        }

                    }
                   
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Something Went Wrong");
                txt_OTP.Clear();
                PayAmount p1 = new PayAmount();
                p1.Show();
                this.Hide();
            }
        }

        #region Number Button
        private void btn_1_Click(object sender, EventArgs e)
        {
            int num = 1;
            txt_OTP.Text = txt_OTP.Text + Convert.ToString(num);
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            int num = 2;
            txt_OTP.Text = txt_OTP.Text + Convert.ToString(num);
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            int num = 3;
            txt_OTP.Text = txt_OTP.Text + Convert.ToString(num);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            int num = 4;
            txt_OTP.Text = txt_OTP.Text + Convert.ToString(num);
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            int num = 5;
            txt_OTP.Text = txt_OTP.Text + Convert.ToString(num);
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            int num = 6;
            txt_OTP.Text = txt_OTP.Text + Convert.ToString(num);
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            int num = 7;
            txt_OTP.Text = txt_OTP.Text + Convert.ToString(num);
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            int num = 8;
            txt_OTP.Text = txt_OTP.Text + Convert.ToString(num);
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            int num = 9;
            txt_OTP.Text = txt_OTP.Text + Convert.ToString(num);
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            int num = 0;
            txt_OTP.Text = txt_OTP.Text + Convert.ToString(num);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

            txt_OTP.Clear();
        }
        #endregion
        private void Transaction(string str)
        {
            long sender = UserLogin.Phone_Number;
            long receiver = PhoneNumberPayment.userNumber;

            db.Transaction(sender, receiver,str);
        }

        private void TransactionB(string str)
        {
            long senderNum = UserLogin.Phone_Number;
            long accNum = BankPayment.accnumber;

            db.TransactionBank(senderNum, accNum,str);
        }
    }
}
