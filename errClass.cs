using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll
{
    class errClass
    {
        public string hours, rate; 
        public double trueRate, trueHours;
        public bool error, isNum;

        public errClass()
        {
            hours = "";
            rate = "";
            trueRate = 0;
            trueHours = 0;
            error = true;
            isNum = false;
        }

        public void ErrCheck(string hours, string rate)
        {
            //isNum check start
			//this performs the actual isNum check, this was orginally designed for the payrollCalculator
			//note that the boolean has 2 parse statements in it
            bool isNum = double.TryParse(hours, out trueHours) && double.TryParse(rate, out trueRate);

			//this is how items are returned
            if (isNum)
            {
                error = false;
            }
            else
            {
                error = true;
                Console.WriteLine("Ensure that you have entered a whole or decimal value");
            }//isNum check end
        }
    }
}
