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
        //Adding multiple person details
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
        public void Edit()
        {
            foreach (var data in addressbook)
            {
                Console.WriteLine("Enter to first name for update");
                string first_Name = Console.ReadLine();

                if (data.First_Name == first_Name)
                {
                    if (addressbook.Contains(data))
                    {
                        Console.WriteLine("1.First_Name\n2.Last_Time\n3.Address\n4.City\n5.State\n6.Zip Code\n7.Phone Number\n8.Email");
                        Console.WriteLine("Choose Your Option");
                        int Option = Convert.ToInt32(Console.ReadLine());

                        switch (Option)
                        {
                            case 1:
                                string first_name = Console.ReadLine();
                                data.First_Name = first_name;
                                break;
                            case 2:
                                string last_Name = Console.ReadLine();
                                data.Last_Name = last_Name;
                                break;
                            case 3:
                                string address = Console.ReadLine();
                                data.Address = address;
                                break;
                            case 4:
                                string city = Console.ReadLine();
                                data.City = city;
                                break;
                            case 5:
                                string state = Console.ReadLine();
                                data.State = state;
                                break;
                            case 6:
                                long zipcode = long.Parse(Console.ReadLine());
                                data.Zip_Code = zipcode;
                                break;
                            case 7:
                                long phonenumber = long.Parse(Console.ReadLine());
                                data.PhoneNumber = phonenumber;
                                break;
                            case 8:
                                string email = Console.ReadLine();
                                data.Email = email;
                                break;
                        }
                        Console.WriteLine("First_Name: {0}\nLast_Time: {1}\nAddress: {2}\nCity: {3}\nState: {4}\nZip Code: {5}\nPhone Number: {6}\nEmail: {7}", data.First_Name, data.Last_Name, data.Address, data.City, data.State, data.Zip_Code, data.PhoneNumber, data.Email);
                    }
                }
            }
        }
        public void Delete()
        {
            Console.WriteLine("Enter to first name to delete");
            string first_Name = Console.ReadLine();

            foreach (var data in addressbook)
            {
                if (data.First_Name == first_Name)
                {
                    addressbook.Remove(data);
                    Console.WriteLine("Sucessfully removed");
                    break;
                }
                else
                {
                    Console.WriteLine("Contact not present");
                }
            }
        }
        public void MultipleAddressBook()
        {
            int i = 1;
            Dictionary<string, List<ContactDetails>> addressbookDict = new Dictionary<string, List<ContactDetails>>();
            Console.WriteLine("No.of address book added");
            int NoofBooks = Convert.ToInt32(Console.ReadLine());
            while (i <= NoofBooks)
            {
                Console.WriteLine("Enter Name");
                string Name = Console.ReadLine();
                Contact();
                addressbookDict.Add(Name, addressbook);
                Console.WriteLine("\n" + Name);
                Display();
                i++;
            }
        }
        public void NoDuplicateEntry()
        {
            List<ContactDetails> addresses = new List<ContactDetails>();
            Console.WriteLine("Enter name to check duplicate name or not");
            string firstname = Console.ReadLine();
            foreach (var data in addressbook)
            {
                if (data.First_Name == firstname)
                {
                    Console.WriteLine("Addrss already Present");
                }
                else
                {
                    Contact();
                }
            }
        }
        public void SearchPerson()
        {
            MultipleAddressBook();
            Console.WriteLine("Search person in a city or state accross the multiple AddressBook");
            string firstname = Console.ReadLine();
            foreach (var data in addressbook)
            {
                if (data.First_Name == firstname)
                {
                    Console.WriteLine("Addrss already Present");
                    Console.WriteLine(data.City);
                    Console.WriteLine(data.State);
                }
                else
                {
                    Console.WriteLine("Person not present in city or State");
                }
            }
        }
    }
}
