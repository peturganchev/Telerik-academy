using System;

class Program
{
    static void Main(string[] args)
    {
        string charface = Console.ReadLine().ToUpper();
        int length = 0;
        switch (charface)
        {
            case "J":
                length = 11;
                break;
            case "Q":
                length = 12;
                break;
            case "K":
                length = 13;
                break;
            case "A":
                length = 14;
                break;
            default:
                length = int.Parse(charface);
                break;
        }
        for (int i = 2; i <= length; i++)
        {
            charface = "";
            switch (i)
            {
                case 11:
                    charface = "J";
                    break;
                case 12:
                    charface = "Q";
                    break;
                case 13:
                    charface = "K";
                    break;
                case 14:
                    charface = "A";
                    break;
                default:
                    charface += i;
                    break;
            }
            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", charface);
        }
    }
}

