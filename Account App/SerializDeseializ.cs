using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBankingApp;
using Newtonsoft.Json;

namespace MyBankingApp
{
    internal class SerializDeseializ
    {
        public static void SerializeData(List<Account> account)
        {
            File.WriteAllText("AccountData.json", JsonConvert.SerializeObject(account));
        }

        public static List<Account> DeserializeData()
        {
            string fileName = "AccountData.json";
            if (File.Exists(fileName))
            {
                string json = File.ReadAllText(fileName);
                return JsonConvert.DeserializeObject<List<Account>>(json);
            }
            else
            {
                return new List<Account>();
            }
        }

    }
}


