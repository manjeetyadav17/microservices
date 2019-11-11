using Account.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Account.Services
{
    public class AccountService: IAccountService
    {
        public static string GetTransactions()
        {
            var client = new HttpClient();
            var response = client.GetAsync("https://localhost:7003/api/Transaction").Result;



            var data = response.Content.ReadAsStringAsync().Result;
            return data;
        }
    }
}
