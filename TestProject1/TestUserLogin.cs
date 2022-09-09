using PaymentGateway.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class TestUserLogin
    {
        RedisDatabase rp=new RedisDatabase();
        [Fact]
        public void Test_GetDetails()
        {
            string phonenum = "8888066767";
            string pas = "Pratikshinde";

          var result=  rp.GetDetails(phonenum, pas);

            Assert.True(result);
        }
        [Fact]
        public void Test_GetDetails_Invalid()
        {
            string phonenum = "1234567891";
            string pass = "asdsdfdgfggh";

            var result = rp.GetDetails(phonenum, pass);

            Assert.False(result);
        }

        [Fact]
        public void Test_Casing()
        {
            string phonenum = "8888066767";
            string pas = "pratikshinde";

            var result = rp.GetDetails(phonenum, pas);

            Assert.False(result);
        }

        [Fact]
        public void Test_PhoneNumberFormat()
        {
            string phonenum = "8888sdfsdf767";
            string pas = "pratikshinde";

            var result = rp.GetDetails(phonenum, pas);

            Assert.False(result);
        }

        [Fact]
        public void Test_WrongPass()
        {
            string num = "8888066767";
            string pass = "sjdfnskdjbfsjd";

            var result = rp.GetDetails(num, pass);
            Assert.False(result);
        }

        [Fact]
        public void Test_WrongNumber()
        {
            string num = "234355465656678778";
            string pass = "Pratikshinde";

            var result = rp.GetDetails(num, pass);
            Assert.False(result);
        }
    }
}
