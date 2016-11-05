using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n ***************************************************************************");
            Console.WriteLine(" **   Welcome to the Celsius / Fahrenheit / Reamur / Kelvin - Converter   **");
            Console.WriteLine(" ***************************************************************************\n\n");
        
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("  Please choose your Input-Type:\n");


            Console.Write("   [");
              Console.ForegroundColor = ConsoleColor.Green;     Console.Write("a");
              Console.ForegroundColor = ConsoleColor.DarkGray;   Console.Write("]  Celsius\n");

            Console.Write("   [");
            Console.ForegroundColor = ConsoleColor.Green; Console.Write("b");
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("]  Fahrenheit\n");

            Console.Write("   [");
            Console.ForegroundColor = ConsoleColor.Green; Console.Write("c");
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("]  Reamur\n");

            Console.Write("   [");
            Console.ForegroundColor = ConsoleColor.Green; Console.Write("d");
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("]  Kelvin\n\n");

            Console.Write("  Input >> ");
            Console.ForegroundColor = ConsoleColor.Yellow;

            char typ = Console.ReadKey().KeyChar;


            if (typ != 'a' && typ != 'b' && typ != 'c' && typ != 'd')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n   ****************************");
                Console.WriteLine("   ** !!! Wrong Decision !!! **");
                Console.WriteLine("   ****************************");
                Console.Write("\n\n   Please type-IN a valid case next time...");
            }
            else
            { 
            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.Write("\n\n Insert your Value (");
            switch (typ)
            {
                case 'a':  Console.Write("Celsius");
                           break;

                case 'b':  Console.Write("Fahrenheit");
                           break;

                case 'c':  Console.Write("Reamur");
                           break;

                case 'd':  Console.Write("Kelvin");
                           break;
            }
            
            Console.Write (") to Convert:  ");


            double temp = 0;
            double.TryParse(Console.ReadLine(), out temp);

            double cel = 0;
            double fah = 0;
            double rea = 0;
            double kel = 0;


            switch (typ)
            {
                case 'a':  //Celsius
                           cel = temp;
                           fah = (9/5)*(cel)+(32);
                           rea = cel*0.8;
                           kel = cel+273.15;
                           break;

                case 'b':  //Fahrenheit
                           fah = temp;
                           //cel = (temp-32)*(5/9);
                           cel = (temp - 32) * 0.555;
                           rea = cel*0.8;
                           kel = cel+273.15;
                           break;

                case 'c':  //Reamur
                           rea = temp;
                           cel = rea/0.8;
                           fah = (9/5)*(cel)+(32);
                           kel = cel+273.15;
                           break;

                case 'd':  //Kelvin
                           kel = temp;
                           cel = kel-273.15;
                           fah = (9/5)*(cel)+(32);
                           rea = cel*0.8;
                           break;
            }


            
            Console.Write("\n\n Celsius:     ");
              Console.ForegroundColor = ConsoleColor.White;
              Console.Write(cel);
              Console.Write(" °C");
              Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\n Fahrenheit:  ");
              Console.ForegroundColor = ConsoleColor.White;
              Console.Write(fah);
              Console.Write(" °F");
              Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\n Reamur:      ");
              Console.ForegroundColor = ConsoleColor.White;
              Console.Write(rea);
              Console.Write(" °Re");
              Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\n Kelvin:      ");
              Console.ForegroundColor = ConsoleColor.White;
              Console.Write(kel);
              Console.Write(" K");

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\n\n   Press Any Key to Close the Converter...");

            }//else end!
            Console.ReadKey();  //wait!
        }
    }
}
