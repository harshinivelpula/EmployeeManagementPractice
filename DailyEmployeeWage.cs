using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementt
{
    public class DailyEmployeeWage
    {
        public static void DailyWage()
        {
            //Constants
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            //Variables
            int emphrs = 0;
            int empwage = 0;
            Random random = new Random();
            int empcheck = random.Next(2);
            if (empcheck == IS_FULL_TIME)
            {
                emphrs = 8;
            }
            else
            {
                emphrs = 0;
            }
            empwage = emphrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("emp wage:" + empwage);
        }
    }
}
