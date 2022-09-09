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
    public partial class PayAmount : Form
    {
        MongoRepo db;
        public static double amt;
        public PayAmount()
        {
            db = new MongoRepo();
            InitializeComponent();
        }

        //Button 1
        private void btn_1_Click(object sender, EventArgs e)
        {
            int num = 1;
            txt_EnterAmount.Text = txt_EnterAmount.Text + Convert.ToString(num);
        }
        //Button 2
        private void btn_2_Click(object sender, EventArgs e)
        {
            int num = 2;
            txt_EnterAmount.Text = txt_EnterAmount.Text + Convert.ToString(num);
        }
        //Button 3
        private void btn_3_Click(object sender, EventArgs e)
        {
            int num = 3;
            txt_EnterAmount.Text = txt_EnterAmount.Text + Convert.ToString(num);
        }
        //Button 4
        private void btn_4_Click(object sender, EventArgs e)
        {
            int num = 4;
            txt_EnterAmount.Text = txt_EnterAmount.Text + Convert.ToString(num);

        }
        //Button 5
        private void btn_5_Click(object sender, EventArgs e)
        {
            int num = 5;
            txt_EnterAmount.Text = txt_EnterAmount.Text + Convert.ToString(num);
        }
        //Button 6
        private void btn_6_Click(object sender, EventArgs e)
        {
            int num = 6;
            txt_EnterAmount.Text = txt_EnterAmount.Text + Convert.ToString(num);
        }
        //Button 7
        private void btn_7_Click(object sender, EventArgs e)
        {
            int num = 7;
            txt_EnterAmount.Text = txt_EnterAmount.Text + Convert.ToString(num);
        }
        //Button 8
        private void btn_8_Click(object sender, EventArgs e)
        {
            int num = 8;
            txt_EnterAmount.Text = txt_EnterAmount.Text + Convert.ToString(num);
        }
        //Button 9
        private void btn_9_Click(object sender, EventArgs e)
        {
            int num = 9;
            txt_EnterAmount.Text = txt_EnterAmount.Text + Convert.ToString(num);
        }
        //Button 0
        private void btn_0_Click(object sender, EventArgs e)
        {
            int num = 0;
            txt_EnterAmount.Text = txt_EnterAmount.Text + Convert.ToString(num);
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_EnterAmount.Clear();

        }

        //Pay Button 
        private void button1_Click(object sender, EventArgs e)
        {
            long number = UserLogin.Phone_Number;
            Random random = new Random();
            int otp = random.Next(999, 9999);

            if (BankPayment.accnumber != 0 && BankPayment.Ifsc != null)
            {
                long accnum = BankPayment.accnumber;
                string Ifsc = BankPayment.Ifsc;

                var result = db.GetBankData(accnum, Ifsc);

            }

          bool flag=  db.ConfirmOT(number, otp);
            if(flag==true)
            {
                amt = Convert.ToDouble(txt_EnterAmount.Text);

                OTPForm op = new OTPForm();
                op.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Something Went Wrong");
                PaymentTypes p1 = new PaymentTypes();
                p1.Show();
                this.Hide();
            }
           

        }
        
        private void PayAmount_Load(object sender, EventArgs e)
        {
            
            
        }

        //BAck Button
        private void btn_Back_Click(object sender, EventArgs e)
        {
            PaymentTypes pt = new PaymentTypes();
            pt.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
