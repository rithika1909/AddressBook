using System;
namespace AddressBook
{
    class Program
    {
        public static void Main(string[] args)
        {

            AddressBook addressbook = new AddressBook();
            addressbook.CreateContact();
            Console.WriteLine("Enter the option to proceed\n 1.Create Contact\n 2.Edit Contact\n");
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
                        Console.WriteLine("Enter the name to edit contact details");
                        string input = Console.ReadLine();
                        addressbook.EditContact(input);
                        break;

                }
            }
        }
    }
    
}

