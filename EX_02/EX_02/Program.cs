using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //opening setup for calculator
            Console.WriteLine("Welcome to your calculator!");
            Calculator c = new Calculator();
            Boolean CalcOn = true;
            do
            {
                //determines what form of arithmetic we are doing
                Console.WriteLine("What would you like to do today? Add, Subtract, Multiply or Divide");
                String choice = Console.ReadLine().ToLower();

                //gets two integers from the user
                Console.WriteLine("Give me two numbers!");
                int x = Convert.ToInt32(Console.ReadLine());
                int y = Convert.ToInt32(Console.ReadLine());

                // determines what functions to use
                if (choice.Contains("add"))
                {
                    c.add(x, y);
                }

                if (choice.Contains("subtract"))
                {
                    c.subtract(x, y);
                }
                if (choice.Contains("multiply"))
                {
                    c.multiply(x, y);
                }
                if (choice.Contains("divide"))
                {
                    c.divide(x, y);
                }

                // asks if user wants to leave or not
                Console.WriteLine("Would you like to calculate again?");
                string state = Console.ReadLine();
                if (state.Contains("no"))
                {
                    CalcOn = false;
                }
            } while (CalcOn == true);
        }
    }

    class Calculator
    {
        //classes for arithmetic
        public double add(int x, int y)
        {
            MessageBox.Show((x + y).ToString());
            return x + y;
        }
        public double subtract(int x, int y)
        {
            MessageBox.Show((x - y).ToString());
            return x - y;
        }
        public double multiply(int x, int y)
        {
            MessageBox.Show((x * y).ToString());
            return x * y;
        }
        public double divide(int x, int y)
        {
            MessageBox.Show((x / y).ToString());
            return x / y;
        }
    }
}
