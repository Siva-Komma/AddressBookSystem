using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Address Book System");
            AddressBook ab = new AddressBook();
            while (true)
            {
                Console.WriteLine("1.Contact\n2.Display");
                Console.WriteLine("Choose your option");
                int Option = Convert.ToInt32(Console.ReadLine());
                switch (Option)
                {
                    case 1:
                        //Contact Deyails of a Person
                        ab.Contact();
                        break;
                    case 2:
                        ab.Display(); 
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
