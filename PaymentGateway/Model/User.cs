using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGateway.Model
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email_Id { get; set; }
        public long Phone_Number { get; set; }
        public List<Transaction> Transaction { get; set; }

    }
    public class Bank
    {
       
        public int Account_Number { get; set; }
        public string? Bank_Name { get; set; }
        public long Phone_Number { get; set; }
        public string IFSC { get; set; }
        public Card Card { get; set; }
        public int Bank_OTP { get; set; }
        public double Amount { get; set; }
    }
    public class Card
    {
        
        public string? Card_Type { get; set; }
        public long Card_Number { get; set; }
        public int OTP { get; set; }
        public short Cvv { get; set; }
        public DateTime ExpireDate { get; set; }

    }
    public class Transaction
    {
        public int Transaction_ID { get; set; }
        public  string Sender { get; set; }
        public long SNumber { get; set; }
        public long LNumber { get; set; }
        public string Receiver { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public string Transaction_Status { get; set; }

    }
}
