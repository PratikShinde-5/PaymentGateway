using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGateway.Repo
{
    public class RedisDatabase
    {
        public IDatabase db;

        public RedisDatabase()
        {
            var option = new ConfigurationOptions
            {
                Password = "AdJdf5hr0Q1HnA3djK8YBRYQOCINYGDZ"
            };
          
            option.EndPoints.Add("redis-18172.c13161.ap-seast-1-mz.ec2.cloud.rlrcp.com:18172");

            ConnectionMultiplexer conn = ConnectionMultiplexer.Connect(option);
            db = conn.GetDatabase();
        }

        //Login USer using redis
        public bool GetDetails(string number, string pass)
        {
             
            pass = string.Join("*0", pass.Reverse());
            var result = db.HashExists("psPayMe", number);

            if(result == true)
            {
                var filpass = db.HashGet("psPayMe", number);

                if(filpass==pass)
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
    }
}
