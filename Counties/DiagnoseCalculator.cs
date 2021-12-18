using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countries
{
   public static class DiagnoseCalculator
    {
        public static string Calculate(int count, int score)
        {
            int percentage = score * 100 / count;
            
            if (percentage < 10)
            {
                return "Географический кретинизм - не приговор!";
            }
             if (percentage < 30)
            {
                return "- Веди нас, Сусанин, веди нас, герой! \n- Идите вы нафиг, я сам тут впервой!";
            }
             if (percentage < 60)
            {
                return "Географ глобус пропил...";
            }
             if (percentage < 80)
            {
                return "Неплохо!";
            }
             if (percentage < 90)
            {
                return "Отлично!";
            }
            return "Федор Конюхов, Вы ли это?";
        }

    }
}
