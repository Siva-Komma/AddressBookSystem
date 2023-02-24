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
                Console.WriteLine("1.Contact\n2.Display\n3.Edit\n4.Delete\n5.MultipeAddressBook");
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
                    case 3:
                        ab.Edit();
                        break;
                    case 4:
                        ab.Delete();
                        break;
                    case 5:
                        ab.MultipleAddressBook();
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
