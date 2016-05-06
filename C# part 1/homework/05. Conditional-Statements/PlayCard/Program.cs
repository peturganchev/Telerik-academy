using System;

namespace PlayCard
{
    class Program
    {
        static void Main()
        {
            string a = Console.ReadLine();
            switch (a)
            {
                case "2": Console.WriteLine("yes {0}", a); break;
                case "3": Console.WriteLine("yes {0}", a); break;
                case "4": Console.WriteLine("yes {0}", a); break;
                case "5": Console.WriteLine("yes {0}", a); break;
                case "6": Console.WriteLine("yes {0}", a); break;
                case "7": Console.WriteLine("yes {0}", a); break;
                case "8": Console.WriteLine("yes {0}", a); break;
                case "9": Console.WriteLine("yes {0}", a); break;
                case "10": Console.WriteLine("yes {0}", a); break;
                case "J": Console.WriteLine("yes {0}", a); break;
                case "Q": Console.WriteLine("yes {0}", a); break;
                case "K": Console.WriteLine("yes {0}", a); break;
                case "A": Console.WriteLine("yes {0}", a); break;
                default: Console.WriteLine("no {0}", a); break;
            }
        }
    }
}
