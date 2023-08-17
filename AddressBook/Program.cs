using System;
namespace AddressBook
{
    class Program
    {
        const string filepath = @"D:\AddressBook\AddressBook\AddressBook.json";
        static string file_path = @"D:\AddressBook\AddressBook\Contact.txt";
        public static void Main(string[] args)
        {
            string key = null, input = null;
            AddressBook addressbook = new AddressBook();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter the option to proceed\n 1.Create Contact\n 2.Add to Dictionary\n 3.Edit Contact\n 4.Delete Contact\n 5.Display Contact\n 7.Search by state or city\n 8.Sort By Name\n 9.Exit");

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
                        flag = false;
                        break;

                }
            }
        }
    }
    
}

