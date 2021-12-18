using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Countries.FileProvider;

namespace Countries
{
   public static class CountryStorage
    {

       static string fileName = "countries.json";



        public static List<Country> countries;
      
        public static List<Country> GetAll()
        {
            if (!File.Exists(fileName))
            {
                countries = new List<Country>
                {
                 new Country("Россия", "Москва"),
                 new Country("Китай", "Пекин"),
                 new Country("США", "Вашингтон"),
                 new Country("Непал", "Катманду"),
                 new Country("Бутан", "Тхимпху"),
                 new Country("Мадагаскар", "Антананариву"),
                 new Country("Новая Зеландия", "Веллингтон"),

                };

                Save();
            }
            else
            {
                countries = JsonConvert.DeserializeObject<List<Country>>(FileProvider.GetValue(fileName));
             
            }
            return countries;

        }
       

        public static void Save()
        {
            var jsonValue = JsonConvert.SerializeObject(countries);
            FileProvider.SaveToFile(fileName, jsonValue);

        }

        public static void AddCountry(Country country)
        {
            countries.Add(country);
            CountryStorage.Save();
        }
            
         


    }
    
}
