using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class AddressBook
    {
        List<ContactDetails> addressbook = new List<ContactDetails>(); 
        public void Contact()
        {
            Console.WriteLine("Enter Contact Details");
            ContactDetails cd = new ContactDetails();
            Console.WriteLine("Enter First_Name");
            cd.First_Name = Console.ReadLine();
            Console.WriteLine("Enter Last_Name");
            cd.Last_Name = Console.ReadLine();
            Console.WriteLine("Enter Address");
            cd.Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            cd.City = Console.ReadLine();
            Console.WriteLine("Enter State");
            cd.State = Console.ReadLine();
            Console.WriteLine("Enter Zip_Code");
            cd.Zip_Code = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Phone_Number");
            cd.PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Email");
            cd.Email = Console.ReadLine();
            addressbook.Add(cd);
        }
        public void Display()
        {
            foreach (ContactDetails cd in addressbook)
            {
                Console.WriteLine("\nDisplaying 1st person details");
                Console.WriteLine("\nFirst_Name: " + cd.First_Name);
                Console.WriteLine("Last_Name: " + cd.Last_Name);
                Console.WriteLine("Address: " + cd.Address);
                Console.WriteLine("City: " + cd.City);
                Console.WriteLine("State: " + cd.State);
                Console.WriteLine("Zip_Code: " + cd.Zip_Code);
                Console.WriteLine("PhoneNumber: " + cd.PhoneNumber);
                Console.WriteLine("Email: " + cd.Email);
            }
        }
    }
}
