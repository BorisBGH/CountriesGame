using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countries
{
    public class Country
    {
        public string Name { get; set; }
        public string Capital { get; set; }


        public Country(string name, string capital)
        {
            Name = name;
            Capital = capital;
        }

    }
}
