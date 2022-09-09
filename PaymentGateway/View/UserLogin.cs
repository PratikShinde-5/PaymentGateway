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

namespace PaymentGateway.View
{

    public partial class UserLogin : Form
    {
        public static long Phone_Number;
        RedisDatabase repo = new RedisDatabase();
        public UserLogin()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string number = txt_PhoneNumber.Text;
            string pass = txt_Pass.Text;

           bool result = repo.GetDetails(number, pass);

            if(result==true)
            {
                
                Phone_Number = Convert.ToInt64(number);
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
