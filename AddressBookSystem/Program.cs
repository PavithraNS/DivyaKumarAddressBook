using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using System.Xml.Linq;

namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {   // start
            Console.WriteLine("Welcome to AddressBook Program");
            Console.WriteLine("Enter: \n1: Ability to create a Contacts in AdressBook\n2: Ability to add a new Contact to Address Book\n3: Edit Contact From Adress Book\n4: Delete contact \n5: Multiple contact \n6: Refactor by using Dictionory"); // taken options of program input from user
            int option =Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    {   //UC1
                        Person person = new Person();
                        person.EntryDetails();
                        //person.DisplayAdressBook("");
                    }
                    break;
                case 2:
                    {    //UC2
                        Person person = new Person();
                        var result=person.EntryDetails();
                        
                    }
                    break;
                case 3:
                    {   //UC3
                        Person person = new Person();
                        person.EntryDetails();
                        person.DisplayAdressBook("AdressBook");
                        person.EditContact();
                        person.DisplayAdressBook("AdressBook");
                    }
                    break;
                case 4:
                    {  //uc4
                        Person person = new Person();
                        person.EntryDetails();
                        person.DisplayAdressBook("AdressBook");
                        person.deleteContact();
                        person.DisplayAdressBook("AdressBook");

                    }
                    break;
                case 5:
                    {  // UC5
                        Person person = new Person();
                        person.EntryDetails();
                        person.DisplayAdressBook("AdressBook");
                    }
                    break;
                case 6:
                    {
                        // UC6
                        Person person = new Person();
                        person.AddNewAddressBook();
                    }
                    break;
                default:
                    Console.WriteLine("Please Enter The Valid Option");
                    break;
            }
        }
    }
}
