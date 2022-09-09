using PaymentGateway.Model;
using PaymentGateway.Repo;

namespace TestProject1
{
    public class UnitTest1
    {
        MongoRepo r1 = new MongoRepo();



        [Fact]
        public void Test_Search_Number()
        {
            //Check Number Valid Or Not
            // present in the list or not
           
            long num = 12345678;
           var result= r1.Search_Number(num);
           
            Assert.Equal(0, result);
        }

        [Fact]
        public void Test_GetRecivedTransaction_Invalid()
        {
            //To check Return list<transaction> or not
            long number = 12345678;
           var result= r1.GetRecivedTransaction(number);
           
          // Assert.NotNull(result);
            Assert.Empty(result);
            foreach(var transaction in result)
            {
               long nu= transaction.LNumber;
                Assert.NotEqual(0, nu);

                long sn = transaction.SNumber;
                Assert.NotEqual(0,sn);

                int tid = transaction.Transaction_ID;
                Assert.NotEqual(0,tid);

                double amt=transaction.Amount;
                Assert.NotEqual(0, amt);

                string sname = transaction.Sender;
                Assert.Null(sname);

                string rname = transaction.Receiver;
                Assert.Null(rname);

                DateTime date = transaction.Date;
                Assert.NotEqual(DateTime.Now,date);

                string status = transaction.Transaction_Status;
                Assert.Null(status);

            }
           
        }  //Recived Invalid Transaction
        [Fact]
        public void Test_GetRecivedTransaction_valid()
        {
            long num = 8888066767;
            var result = r1.GetRecivedTransaction(num);

            Assert.NotNull(result);
            foreach(var transaction in result)
            {
                long nu = transaction.LNumber;
                Assert.NotEqual(0, nu);

                long sn = transaction.SNumber;
                Assert.NotEqual(0, sn);

                int tid = transaction.Transaction_ID;
                Assert.NotEqual(0, tid);

                double amt = transaction.Amount;
                Assert.NotEqual(0, amt);

                string sname = transaction.Sender;
                Assert.NotNull(sname);

                string rname = transaction.Receiver;
                Assert.NotNull(rname);

                DateTime date = transaction.Date;
                Assert.NotEqual(DateTime.Now, date);

                string status = transaction.Transaction_Status;
                Assert.NotNull(status);


            }
        } //Recived Valid Transaction

        [Fact]
        public void Test_GetSendTransaction_Valid()//Send Transaction Valid 
        {
            long number = 8888066767;
          var result=  r1.GetSendTransaction(number);

            Assert.NotEmpty(result);


        }
        [Fact]
        public void Test_GetSendTransaction_InValid()//Send Transaction InValid 
        {
            long number =1233435;
            var result = r1.GetSendTransaction(number);

            Assert.Empty(result);


        }

        [Fact]
        public void Test_ConfirmOT_Valid()// Confirm OTP Correct
        {
            long number = 8888066767;
            int otp = 1234;
            var result = r1.ConfirmOT(number, otp);

            Assert.True(result);
        }

        [Fact]
        public void Test_GetBalance()
        {
            long number = 8888066767;
          var result=  r1.GetBalance(number);

            Assert.NotNull(result);
        } //Get balance

        [Fact]
        public void Test_GetBalance_Invalid()
        {
            long number = 1234567;
            var result = r1.GetBalance(number);

            Assert.Null(result);
        } //Get Balance using Unvalid Number 

        [Fact]
        public void Test_GetBankData_Invalid() // Get Bank Data using Incorrect Data 
        {
            long accnum = 12344534645747;
            string ifsc = "sdfjfbsdjgfs";
          var result=  r1.GetBankData(accnum,ifsc);

            Assert.Null(result);
            
        }

        [Fact]
        public void Test_GetBankData_Valid()//get Bank data using correct data
        {
            long accnum = 8888066767;
            string ifsc = "SBIN0005943";
            var result = r1.GetBankData(accnum, ifsc);

            Assert.Null(result);

        }
        [Fact]
        public void Test_GetBankData_InvalidNumber()//get Bank data using Invalid data
        {
            long accnum = 122364346575;
            string ifsc = "SBIN0005943";
            var result = r1.GetBankData(accnum, ifsc);

            Assert.Null(result);

        }
        [Fact]
        public void Test_GetBankData_InvalidIfsc()//get Bank data using Invalid data
        {
            long accnum = 122364346575;
            string ifsc = "SBIN0005943";
            var result = r1.GetBankData(accnum, ifsc);

            Assert.Null(result);

        }
    }
}