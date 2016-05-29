using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class VariableLength
{
    static string toBinary(string number)//convert to binary
    {
        return Convert.ToString(byte.Parse(number), 2).PadLeft(8, '0');
    }
    static void Main()
    {
        string input = string.Join("", Console.ReadLine() //read the line and converts the array to string
            .Split(' ')         // split the space between numbers
            .Select(toBinary)   // convert to binary
            .ToArray());        // convert to array
        // we get the length of every sequence of 1's 
        IEnumerable<int> code = input.Split(new char[] { '0' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(x => x.Length);  
        int length = int.Parse(Console.ReadLine()); // N-lines
        char[] array = new char[length + 1];
        for (int i = 0; i < length; i++) 
        {
            string line = Console.ReadLine(); // read the line
            int index = int.Parse(line.Substring(1)); //get the second value(number)
            array[index] = line[0]; //get the first value(char) and put it at position index of the array
        }
        char[] text = code.Select(x => array[x]).ToArray(); // we take the value for every number in code and write the char from array
        Console.WriteLine(text);
    }
}
