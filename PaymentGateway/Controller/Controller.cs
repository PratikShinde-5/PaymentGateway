using PaymentGateway.Model;
using PaymentGateway.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGateway.Controller
{
    //Not any Important
    public class Controller
    {
        MongoRepo db = new MongoRepo();
        public void AddUser()
        {
            Transaction t1 = new Transaction();

        }
        public void AddBandDetails()
        {
            Bank b1 = new Bank();

            Card c1 = new Card();

            b1.Card = c1;



        }
    }
}
