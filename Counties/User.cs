using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countries
{
    public class User
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public string Diagnose { get; set; }

        public User(string name)
        {
            Name = name;
        }

        public void AcceptAnswer()
        {
            Score++;
        }
    }
}
