using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Finds preferred name of individual
            Console.WriteLine("I see you are known as {0} what would you like me to call you instead?", Environment.UserName);
            string Name = Console.ReadLine();

            //Takes name and finds out how old user is
            Console.WriteLine(Name + " How old are you?");
            int Age = Convert.ToInt32(Console.ReadLine());

            //determines color of background
            if (Age < 18)
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            //Write Hello <name>
            Console.WriteLine("Hello," + Name + "!");

            //Message box + beep if its a minor
            String Warning = "Danger, " + Name + " Robinson! Danger!";
            MessageBox.Show(Warning);
            if (Age < 18)
            {
                Console.Beep();
            }

            //end code
            Console.ReadLine();
        }
    }
}
