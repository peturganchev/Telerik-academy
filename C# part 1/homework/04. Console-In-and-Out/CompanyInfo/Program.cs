using System;

namespace CompanyInfo
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            string address = Console.ReadLine();
            string phone = Console.ReadLine();
            string fax = null;
            fax = Console.ReadLine();
            string website = Console.ReadLine();
            string mFirstName = Console.ReadLine();
            string mLastName = Console.ReadLine();
            string mAge = Console.ReadLine();
            string mPhone = Console.ReadLine();
            Console.WriteLine(name);
            Console.WriteLine("Address: {0}", address);
            Console.WriteLine("Tel. {0}", phone);
            if (fax == "")
            {
                Console.WriteLine("Fax: (no fax)");
            }
            else
            {
                Console.WriteLine("Fax: {0}", fax);
            }

            Console.WriteLine("Web site: {0}", website);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", mFirstName, mLastName, mAge, mPhone);
        }
    }
}
