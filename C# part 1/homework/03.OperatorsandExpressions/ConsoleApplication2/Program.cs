using System;

public class ModifyBit
{
    public static void Main()
    {
        ulong numberN = ulong.Parse(Console.ReadLine());
        int positionP = int.Parse(Console.ReadLine());
        byte bitValueV = byte.Parse(Console.ReadLine());
        ulong mask = bitValueV;
        ulong numberAndMask;

        //if (bitValueV == 0)
        //{
        //    numberAndMask = ~(mask << positionP) & numberN;
        //}
        //else
        //{
        //    numberAndMask = numberN | mask << positionP;
        //}
        numberAndMask = numberN | mask << positionP;
        Console.WriteLine(numberAndMask);
    }
}