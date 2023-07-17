using System;
namespace AddressBook
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook");
            AddressBook addressbook = new AddressBook();
            addressbook.CreateContact();

        }

    }
    
}

