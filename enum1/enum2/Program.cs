using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum2
{
    class Program
    {

        static void check(Post p, int h)
        {
            if (Accauntant.AskFoorBonus(p, h))
                Console.WriteLine("You`ve got bonus!");
            else
                Console.WriteLine("No Bonus");
        }

        static void Main(string[] args)
        {
            Post p;
            Console.WriteLine("Choose your profession: ");
            Array a = Enum.GetValues(typeof(Post));
            for(int i = 0; i < a.Length; i++)
                Console.WriteLine("{0} - {1}", i+1, a.GetValue(i));
            int c, hours;
            int.TryParse(Console.ReadLine(), out c);
            Console.WriteLine("Enter the hours: ");
            int.TryParse(Console.ReadLine(), out hours);
            switch (c)
            {
                case 1:
                    p = Post.Secretary;
                    check(p, hours);
                    break;
                case 2:
                    p = Post.Manager;
                    check(p, hours);
                    break;
                case 3:
                    p = Post.Booker;
                    check(p, hours);
                    break;
                case 4:
                    p = Post.Administrator;
                    check(p, hours);
                    break;
                case 5:
                    p = Post.Programmer;
                    check(p, hours);
                    break;
                default:
                    Console.WriteLine("Wrong option.");
                    break;
            }
           
            Console.ReadLine();
        }
    }
}
