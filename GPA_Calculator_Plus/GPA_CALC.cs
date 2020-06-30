using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_Calculator_Plus
{
   public static class GPA_CALC
    {
        public static bool isNum(string str)
        {
            int flag = 0;
            for (int i = 0; i < str.Length; i++)
            {

                if (str[i] == '.')
                {
                    if (flag==1) //两个
                        return false;
                    flag = 1;
                }
                else if (str[i] < '0' || str[i] > '9')
                {
                    return false;
                }
            }
            return true;
        }
        public static double Convert2GPA(double avg)
        {
            if (avg >= 95 && avg <= 100)
                return 4.3;
            else if (avg >= 90 && avg < 95)
                return 4.0;
            else if (avg >= 85 && avg < 90)
                return 3.7;
            else if (avg >= 80 && avg < 85)
                return 3.3;
            else if (avg >= 75 && avg < 80)
                return 3.0;
            else if (avg >= 70 && avg < 75)
                return 2.7;
            else if (avg >= 67 && avg < 70)
                return 2.4;
            else if (avg >= 65 && avg < 67)
                return 2.0;
            else if (avg >= 62 && avg < 65)
                return 1.7;
            else if (avg >= 60 && avg < 62)
                return 1.0;
            else
                return 0;
        }
    }
}
