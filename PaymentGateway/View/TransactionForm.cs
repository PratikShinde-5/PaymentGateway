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
    public partial class TransactionForm : Form
    {
        MongoRepo db = new MongoRepo();
        public TransactionForm()
        {
            InitializeComponent();
        }

        //Back Button
        private void btn_Back_Click(object sender, EventArgs e)
        {
            WelComeForm wc = new WelComeForm();
            wc.Show();
            this.Hide();
        }

        //Transaction Load In Database
        private void TransactionForm_Load(object sender, EventArgs e)
        {
            var result = db.GetSendTransaction(UserLogin.Phone_Number);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = result;

            var result1 = db.GetRecivedTransaction(UserLogin.Phone_Number);
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = result1;

        }
    }
}
