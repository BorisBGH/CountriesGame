using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countries
{
    public static class InputChecker
    {
        public static bool CheckUserInput(string userInput)
        {
            if (string.IsNullOrEmpty(userInput) || string.IsNullOrWhiteSpace(userInput))
            {
                return false;
            }


            foreach (var item in userInput)
            {
                if (!char.IsLetter(item))
                {
                    return false;
                }


            }
            return true;

        }
    }
}
