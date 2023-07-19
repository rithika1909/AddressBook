using System;
namespace AddressBook
{
    class Program
    {
        public static void Main(string[] args)
        {

            AddressBook addressbook = new AddressBook();
            Console.WriteLine("Enter the option to proceed\n 1.Create Contact\n 2.Add to Dictionary\n 3.Edit Contact\n 4.Display Contact\n 5.Exit ");
            bool flag = true;
            while (flag)
            {
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
                        Console.WriteLine("Enter the name of contact details to be deleted");
                        string name = Console.ReadLine();
                        addressbook.EditContact(name);
                        break;
                    case 4:
                        addressbook.Display();
                        break;
                    case 5:
                        flag = false;
                        break;

                }
            }
        }
    }
    
}

