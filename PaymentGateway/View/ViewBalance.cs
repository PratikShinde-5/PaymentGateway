using MongoDB.Bson.IO;
using Newtonsoft.Json.Linq;
using PaymentGateway.Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using JsonConvert = Newtonsoft.Json.JsonConvert;

namespace PaymentGateway.View
{
    public partial class ViewBalance : Form
    {
        MongoRepo db = new MongoRepo();
       
        public ViewBalance()
        {
            InitializeComponent();
        }

        //View balance
        private void ViewBalance_Load(object sender, EventArgs e)
        {
            try
            {
                long number = UserLogin.Phone_Number;
                var result = db.GetBalance(number);

                txt_Amount.Text = Convert.ToString(result["Amount"]);
                txt_BankName.Text = Convert.ToString(result["Bank_Name"]);


            }
            catch (Exception)
            {

                MessageBox.Show("Something Went Wrong");
                
            }
        }

        //Currency Converter
        private void CurrencyCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
               
                string url = $"https://services.api.umrahme.net/v1/demo-forex?from=INR&to={CurrencyCombo.Text}";
                HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
                var httpResult = Http_SingletonPattern.Client.SendAsync(requestMessage).Result;
                if (httpResult.StatusCode == HttpStatusCode.OK)
                {
                    var result = httpResult.Content.ReadAsStringAsync();


                    var response = JsonConvert.DeserializeObject<JObject>(result.Result);


                    double amount = Convert.ToDouble(response["Values"][0]["Value"]);

                        double price = Convert.ToDouble(txt_Amount.Text);

                        double amt = amount*price ;

                        txt_Amount.Text = Convert.ToString(Math.Round(amt, 3));

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Server Busy ");

            }

        }
        //Back Button
        private void btn_Back_Click(object sender, EventArgs e)
        {
            WelComeForm wc = new WelComeForm();
            wc.Show();
            this.Hide();
        }

        private void CurrencyCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}