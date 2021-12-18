using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countries
{
    class UserResultsStorage
    {

      public static  List<User> users;
      static string fileName = "results.json";

        public static void  Save(User user)
        {

            if (File.Exists(fileName))
            {
                users = JsonConvert.DeserializeObject<List<User>>(FileProvider.GetValue(fileName));

            }
            else
            {
                users = new List<User>();
            }
            
            users.Add(user);

            var jsonData = JsonConvert.SerializeObject(users);
            FileProvider.SaveToFile(fileName, jsonData);
        }

        public static List<User> GetResults()
        {
            List<User> results = JsonConvert.DeserializeObject<List<User>>(FileProvider.GetValue(fileName));
            return results;
        }

    }
}
