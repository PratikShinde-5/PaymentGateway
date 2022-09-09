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
    public partial class LoginForm : Form
    {
        public static long Phone_Number;
        MongoRepo db = new MongoRepo();
        public LoginForm()
        {
            InitializeComponent();
        }

        //LoginButton 

        private void button1_Click_1(object sender, EventArgs e)
        {
            long number = Convert.ToInt64(txt_Number.Text);
            string email = txt_Email.Text;

            bool flag = db.LoginUser(number, email);
            if (flag == true)
            {
                Phone_Number = number;
                MessageBox.Show("Login Success");
                WelComeForm f1 = new WelComeForm();
                f1.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Login Failed");
            }

        }
    }
}
