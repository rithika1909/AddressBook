﻿using System;
namespace AddressBook
{
    class Program
    {
        const string filepath = @"D:\AddressBook\AddressBook\AddressBook.json";
        static string file_path = @"D:\AddressBook\AddressBook\Contact.txt";
        static string csvFilepath = @"D:\AddressBook\AddressBook\Contact.csv";
       
        public static void Main(string[] args)
        {
            string key = null, input = null;
            AddressBook addressbook = new AddressBook();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter the option to proceed\n 1.Create Contact\n 2.Add to Dictionary\n 3.Edit Contact\n 4.Delete Contact\n 5.Display Contact\n 7.Search by state or city\n 8.Sort By Name\n 9.Write to File\n 10.Read from File\n 11.Write as CSV File\n 12.Read as CSV File\n 13.Write as JSON File\n 14.Read as JSON File\n 15.Exit");

                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addressbook.CreateContact();
                        break;
                    case 2:
                        addressbook.AddAddressBookToDictionary();
                        break;
                    case 3:
                        Console.WriteLine("Enter key");
                        key = Console.ReadLine();
                        Console.WriteLine("Enter the name of contact details to be deleted");
                        string name = Console.ReadLine();
                        addressbook.EditContact(key,input);
                        break;
                    case 4:
                        Console.WriteLine("Enter Key");
                        key = Console.ReadLine();
                        Console.WriteLine("Enter the name of contact details to be deleted");
                        input = Console.ReadLine();
                        addressbook.DeleteContact(key, input);
                        break;
                    case 5:
                        addressbook.Display();
                        break;
                    case 6:
                        addressbook.AddToJsonFile(filepath);
                        break;
                    case 7:
                        addressbook.SearchByCityOrState();
                        break;
                    case 8:
                        addressbook.Sort();
                        break;
                    case 9:
                        addressbook.ReadFromStreamReader(file_path);
                        break;
                    case 10:
                        addressbook.WriteFromStreamWriter(file_path);
                        break;
                    case 11:
                        addressbook.WriteFromCSVfile(csvFilepath);
                        break;
                    case 12:
                        addressbook.ReadFromCSVFile(csvFilepath);
                        break;
                    case 13:
                        addressbook.AddToJsonFile(filepath);
                        break;
                    case 14:
                        addressbook.ReadFromJsonFile(filepath);
                        break;
                    case 15:
                        flag = false;
                        break;

                }
            }
        }
    }
    
}

