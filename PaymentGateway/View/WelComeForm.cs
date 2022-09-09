using PaymentGateway.Repo;
using PaymentGateway.View;

namespace PaymentGateway
{
    public partial class WelComeForm : Form
    {
        MongoRepo db = new MongoRepo();
        public WelComeForm()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            PaymentTypes py = new PaymentTypes();
            py.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lb_Name.Text = Convert.ToString(UserLogin.Phone_Number);
        }

        //View Balance
        private void btn_View_Click(object sender, EventArgs e)
        {
            ViewBalance vw = new ViewBalance();
            vw.Show();
            this.Hide();
        }

        private void btn_Transaction_Click(object sender, EventArgs e)
        {
            TransactionForm tc = new TransactionForm();
            tc.Show();
            this.Hide();

        }
        //Log Out
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }
    }
}