using System;
using System.Linq;

namespace Contacts
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a menu number");
                Console.WriteLine("1. List Contacts");
                Console.WriteLine("2. Add Contact");
                Console.WriteLine("3. Delete Contact");
                Console.WriteLine("4. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                if(option == 1)
                {
                    File.ReadFile();
                    int index = 1;
                    foreach(Contact c in File.contactList)
                    {
                        Console.WriteLine($"{index}.  {c.FirstName} {c.LastName}, {c.PhoneNumber}, {c.Email}, " +
                            $"{c.StreetAddress}, {c.City}, {c.State}, {c.ZipCode}");
                        index++;
                    }
                }
                else if(option == 2)
                {
                    File.AddContactToFile();
                }
                else if(option == 3)
                {
                    Console.WriteLine("Enter the number of the contact to delete: ");
                    int delete = Convert.ToInt32(Console.ReadLine());
                    if(delete <= 0 || delete > File.contactList.Count())
                    {
                        Console.WriteLine("Error, number not in range.  Try again.");
                        break;
                    }
                    else
                    {
                        File.contactList.RemoveAt(delete - 1);
                        File.RemoveContact();
                    }
                }
                else if(option == 4)
                {
                    Console.WriteLine("Exiting.....");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Entry.  Try again");
                    break;
                }
            }
        }

    }
}
