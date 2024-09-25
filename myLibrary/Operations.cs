using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLibrary
{
    public class Operations
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public bool isEven(int number)
        {
            return number % 2 == 0;
        }

        public double AddDecimal(double number, double number2)
        {
            return number + number2;
        }
    } 
}
