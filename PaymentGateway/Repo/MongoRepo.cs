using MongoDB.Bson;
using MongoDB.Driver;
using PaymentGateway.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGateway.Repo
{
    public class MongoRepo
    {
        private readonly IMongoCollection<BsonDocument> usercollection;
        private readonly IMongoCollection<BsonDocument> bankCollection;
        private readonly IMongoCollection<BsonDocument> TransactionCollection;
        Transaction t1;
        public MongoRepo()
        {
            MongoClient client = new MongoClient("mongodb+srv://fresher_poc:bbnkZ109ciILSW1L@umrahmedevcluster.zhbmx.mongodb.net/Poc"); // local database

            var database = client.GetDatabase("Poc");


            usercollection = database.GetCollection<BsonDocument>("ps_PayMe_UserDetails");
            bankCollection = database.GetCollection<BsonDocument>("ps_PayMe_BankDetails");
            TransactionCollection = database.GetCollection<BsonDocument>("ps_Payme_Transaction");
        }

       
        //search number
        public int Search_Number(long number)
        {
            try
            {
                var filter = Builders<BsonDocument>.Filter.Eq("Phone_Number", number);

                var result = bankCollection.Find(filter).FirstOrDefault();
                return result.Count();

            }
            catch (Exception)
            {

                return 0;
            }
        }

        //Pay Amount
        public int Pay_Amount(double price, long Snumber,long Rnumber)
        {
            try
            {
                var filter = Builders<BsonDocument>.Filter.Eq("Phone_Number", Snumber);
                var filter2= Builders<BsonDocument>.Filter.Eq("Phone_Number", Rnumber);
                
                var doc = bankCollection.Find(filter).FirstOrDefault();

                var doc2 = bankCollection.Find(filter2).FirstOrDefault();

                if (doc != null && doc2!=null)
                {
                    double Sendamount = (double)doc["Amount"];

                    double reciveAmount = (double)doc2["Amount"];
                    if (Sendamount != 0)
                    {
                        if (Sendamount >= price)
                        {
                            double up = Sendamount - price;
                            var filt = Builders<BsonDocument>.Filter.Eq("Phone_Number", Snumber);
                            var update = Builders<BsonDocument>.Update.Set("Amount", up);

                            bankCollection.UpdateOne(filt, update);

                            double adAmount = reciveAmount + price;

                            var fil = Builders<BsonDocument>.Filter.Eq("Phone_Number",Rnumber);
                            var update2 = Builders<BsonDocument>.Update.Set("Amount",adAmount);
                            bankCollection.UpdateOne(fil, update2);
                            return doc.Count();
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    else
                    {
                        return 0;
                    }

                }
                else
                {
                    return 0;
                }

            }
            catch (Exception)
            {

                return 0;
            }
           
        }

        //Transaction For PhoneNumber
        public void Transaction(long sender, long receiver, string str)
        {
            try
            {
                var filter1 = Builders<BsonDocument>.Filter.Eq("Phone_Number", sender);
                var filter2 = Builders<BsonDocument>.Filter.Eq("Phone_Number", receiver);

                var result1=usercollection.Find(filter1).FirstOrDefault();
                var result2=usercollection.Find(filter2).FirstOrDefault();

                string senderName = (string)result1["Name"];
                string reciverName = (string)result2["Name"];

                Transaction t1 = new Transaction();
                Random random = new Random();
                t1.Transaction_ID = random.Next(999, 10000);
                t1.Sender=senderName;
                t1.SNumber = sender;
                t1.LNumber = receiver;      
                t1.Receiver = reciverName;
                t1.Date = DateTime.UtcNow;
                t1.Amount = PayAmount.amt;
                t1.Transaction_Status = str;


                TransactionCollection.InsertOne(t1.ToBsonDocument());


            }
            catch (Exception)
            {

                throw;
            }
        }

        //Transaction For Bank
        public void TransactionBank(long senderNum, long accNum, string str)
        {
            try
            {
                var filter1 = Builders<BsonDocument>.Filter.Eq("Phone_Number", senderNum);
                var filter2 = Builders<BsonDocument>.Filter.Eq("Account_Number", accNum);

                var result1 = usercollection.Find(filter1).FirstOrDefault();
                var result2 = bankCollection.Find(filter2).FirstOrDefault();

                long pnum = result2["Phone_Number"].ToInt64();
                var filter3 = Builders<BsonDocument>.Filter.Eq("Phone_Number", pnum);
                var result3 = usercollection.Find(filter3).FirstOrDefault();
                string senderName = (string)result1["Name"];
                string reciverName = (string)result3["Name"];

                Transaction t1 = new Transaction();
                Random random = new Random();
                t1.Transaction_ID = random.Next(999, 10000);
                t1.Sender = senderName;
                t1.SNumber = senderNum;
                t1.LNumber = result2["Phone_Number"].ToInt64();
                t1.Receiver = reciverName;
                t1.Date = DateTime.UtcNow;
                t1.Amount = PayAmount.amt;
                t1.Transaction_Status = str;


                TransactionCollection.InsertOne(t1.ToBsonDocument());


            }
            catch (Exception)
            {

            }
        }

        //Pay in Bank Using Acc
        public int Pay_AmountInBank(double price, long acc, string ifsc, long phoneNum)
        {
            try
            {

                var filter = Builders<BsonDocument>.Filter.Eq("Phone_Number", phoneNum);
                var filter2 = Builders<BsonDocument>.Filter.Eq("Account_Number", acc);

                var doc = bankCollection.Find(filter).FirstOrDefault();

                var doc2 = bankCollection.Find(filter2).FirstOrDefault();

                if (doc != null && doc2 != null)
                {
                    double Sendamount = (double)doc["Amount"];

                    double reciveAmount = (double)doc2["Amount"];
                    if (Sendamount != 0)
                    {
                        if (Sendamount >= price)
                        {
                            double up = Sendamount - price;
                            var filt = Builders<BsonDocument>.Filter.Eq("Phone_Number", phoneNum);
                            var update = Builders<BsonDocument>.Update.Set("Amount", up);

                            bankCollection.UpdateOne(filt, update);

                            double adAmount = reciveAmount + price;

                            var fil = Builders<BsonDocument>.Filter.Eq("Account_Number", acc) &
                                Builders<BsonDocument>.Filter.Eq("IFSC", ifsc);
                            var update2 = Builders<BsonDocument>.Update.Set("Amount", adAmount);
                            bankCollection.UpdateOne(fil, update2);
                            return doc.Count();
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    else
                    {
                        return 0;
                    }

                }
                else
                {
                    return 0;
                }

            }
            catch (Exception)
            {

                return 0;
            }
        }

        public BsonDocument? GetBankData(long accnum, string ifsc)
        {
            try
            {
                var filter = Builders<BsonDocument>.Filter.Eq("Account_Number", accnum) &
                    Builders<BsonDocument>.Filter.Eq("IFSC", ifsc);
                var result = bankCollection.Find(filter).FirstOrDefault();

                if (result != null)
                {
                    return result;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        //View Balance
        public BsonDocument? GetBalance(long number)
        {
            try
            {
                var filter = Builders<BsonDocument>.Filter.Eq("Phone_Number", number);

                var result = bankCollection.Find(filter).FirstOrDefault();

                if (result != null)
                {
                    return result;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {

                return null;
            }

        }

        //Confirm OTP to proceed
        public BsonDocument? ConfirmOTP(long number, int checkotp)
        {
            try
            {
                var filter = Builders<BsonDocument>.Filter.Eq("Phone_Number", number) &
               Builders<BsonDocument>.Filter.Eq("Bank_OTP", checkotp);

                var result = bankCollection.Find(filter).FirstOrDefault();

                if (result != null)
                {
                    return result;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {

                return null;
            }
        }

        //Create OTP
        public bool ConfirmOT(long number, int otp)
        {
            try
            {
                var filter = Builders<BsonDocument>.Filter.Eq("Phone_Number", number);

                var update = Builders<BsonDocument>.Update.Set("Bank_OTP", otp);

                var result = bankCollection.UpdateOne(filter, update);

                if (result != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception)
            {

                return false;
            }
        }

        //Reciever Transaction
        public List<Transaction> GetRecivedTransaction(long phone_Number)
        {
            try
            {
                var filter = Builders<BsonDocument>.Filter.Eq("LNumber", phone_Number);

                var result = TransactionCollection.Find(filter).ToList();

                List<Transaction> list = new List<Transaction>();

                foreach (var item in result)
                {
                    t1 = new Transaction();
                    t1.Transaction_ID = item["Transaction_ID"].ToInt32();
                    t1.Sender = item["Sender"].ToString();
                    t1.SNumber = item["SNumber"].ToInt64();
                    t1.LNumber = item["LNumber"].ToInt64();
                    t1.Receiver = item["Receiver"].ToString();
                    t1.Date = Convert.ToDateTime(item["Date"]);
                    t1.Amount = item["Amount"].ToDouble();
                    t1.Transaction_Status = item["Transaction_Status"].ToString();

                    list.Add(t1);
                }
                return list;
            }
            catch (Exception)
            {

                return null;
            }
        }

        //Sender Transaction
        public List<Transaction> GetSendTransaction(long phone_Number)
        {
            try
            {
                var filter = Builders<BsonDocument>.Filter.Eq("SNumber", phone_Number);

                var result = TransactionCollection.Find(filter).ToList();

                List<Transaction> list = new List<Transaction>();

                foreach (var item in result)
                {
                    t1 = new Transaction();
                    t1.Transaction_ID = item["Transaction_ID"].ToInt32();
                    t1.Sender = item["Sender"].ToString();
                    t1.SNumber = item["SNumber"].ToInt64();
                    t1.LNumber = item["LNumber"].ToInt64();
                    t1.Receiver = item["Receiver"].ToString();
                    t1.Date = Convert.ToDateTime(item["Date"]);
                    t1.Amount = item["Amount"].ToDouble();
                    t1.Transaction_Status = item["Transaction_Status"].ToString();

                    list.Add(t1);
                }
                return list;
            }
            catch (Exception)
            {

                return null;
            }
        }

        //Login User in mongo
        public bool LoginUser(long number, string email)
        {
            try
            {
                string e1 = email;
                email = string.Join("*0", email.Reverse());
                var filter = Builders<BsonDocument>.Filter.Eq("Phone_Number", number)
                    & Builders<BsonDocument>.Filter.Eq("Hobbies", email);


                var result = usercollection.Find(filter).FirstOrDefault();

                if (result != null)
                {
                    string newstr = result["Hobbies"].ToString();
                    string hobbie = string.Join("", newstr.Reverse());
                    hobbie = hobbie.Replace("*", "").Replace("0", "");
                    if (result["Phone_Number"] == number && hobbie == e1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;

            }
        }
    }
}
