using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum1
{

    static class ColorString
    {
        public static void Print(string str, int color)
        {
            switch (color)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(str);
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(str);
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(str);
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(str);
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(str);
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(str);
                    break;
                default:
                    Console.WriteLine("Wrong option");
                    break;
            }   
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int c;
            Console.WriteLine("Enter a string:");
            s = Console.ReadLine();
            Console.WriteLine("Choose a color:");
            Array a = Enum.GetValues(typeof(Colors));
            for(int i = 0; i < a.Length; i++)
                Console.WriteLine("{0} - {0:D}", a.GetValue(i));

            int.TryParse(Console.ReadLine(), out c);
            ColorString.Print(s, c);

            Console.ReadLine();
        }
    }
}
