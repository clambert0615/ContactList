using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Contacts
{
    public class File
    {
        public static List<Contact> contactList = new List<Contact>();
        public static void ReadFile()
        {
            
            contactList.Clear();
            string[] info = new string[] { };
            StreamReader reader = new StreamReader("../../../contacts2.txt");
            string line = reader.ReadLine();
            while(line != null)
            {
                info = line.Split('|');
                contactList.Add(new Contact(info[0], info[1], info[2], info[3], info[4], info[5], info[6], int.Parse(info[7])));
                line = reader.ReadLine();
            }
            reader.Close();
        }

        public static void AddContactToFile()
        {
            Console.WriteLine("Enter First Name: ");
            string firstName = Console.ReadLine().Trim();
            Console.WriteLine("Enter Last Name: ");
            string lastName = Console.ReadLine().Trim();
            Console.WriteLine("Enter Phone Number: ");
            string phoneNumber = Console.ReadLine().Trim();
            Console.WriteLine("Enter Email: ");
            string email = Console.ReadLine().Trim();
            Console.WriteLine("Enter Street Address: ");
            string streetAddress = Console.ReadLine().Trim();
            Console.WriteLine("Enter City: ");
            string city = Console.ReadLine().Trim();
            Console.WriteLine("Enter State: ");
            string state = Console.ReadLine().Trim();
            int zipcode;
            while(true)
            {
                Console.WriteLine("Enter Zip Code: ");
                string zip = Console.ReadLine().Trim();
                try
                {
                    zipcode = int.Parse(zip);
                    if(zipcode < 0)
                    {
                        throw new Exception("Zip code must be positive");
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter numbers");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            contactList.Add(new Contact(firstName, lastName, phoneNumber, email, streetAddress, city, state, zipcode));
            StreamWriter writer = new StreamWriter("../../../contacts2.txt");
            foreach(Contact c in contactList)
            {
                writer.WriteLine($"{c.FirstName}|{c.LastName}|{c.PhoneNumber}|{c.Email}|{c.StreetAddress}|{c.City}|{c.State}|{c.ZipCode}");

            }
            writer.Close();
        }

        public static void RemoveContact()
        {
            StreamWriter writer = new StreamWriter("../../../contacts2.txt");
            foreach (Contact c in contactList)
            {
                writer.WriteLine($"{c.FirstName}|{c.LastName}|{c.PhoneNumber}|{c.Email}|{c.StreetAddress}|{c.City}|{c.State}|{c.ZipCode}");

            }
            writer.Close();
        }
    }
}
