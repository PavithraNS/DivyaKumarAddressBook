using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AddressBookSystem
{
    public class Person // class 
    {
        
        public static List<Contact> people = new List<Contact>();// list
        public Dictionary<string, List<Contact>> contactDictionary=new Dictionary<string, List<Contact>>();
       
        
        // Method for input contact details  
        public List<Contact> EntryDetails()
        {
            Console.WriteLine("Enter the Number of AddressBook do you want to make");
            int numAddressBook = Convert.ToInt32(Console.ReadLine());
            string addressBookName="";
            int n = 0;
            while (n < numAddressBook)
            {
                Console.WriteLine("Enter addressbook name to add contacts");
                addressBookName = Console.ReadLine();
                Console.WriteLine("Enter the Number of Contact You Wanted to add in addressBook:{0}",addressBookName);
                int numContact = Convert.ToInt32(Console.ReadLine());
                people = new List<Contact>();
                for (int i = 1; i <= numContact; i++)
                {
                    //people = new List<Person>();
                    Contact person = new Contact();
                    Console.WriteLine("Enter the details of Contact {0}", i); ;
                    Console.WriteLine("Enter your 1st Name:");
                    person.firstName = Console.ReadLine();
                    Console.WriteLine("Enter your last Name:");
                    person.lastName = Console.ReadLine();
                    Console.WriteLine("Enter your Address:");
                    person.address = Console.ReadLine();
                    Console.WriteLine("Enter your City:");
                    person.city = Console.ReadLine();
                    Console.WriteLine("Enter your Zip Code:");
                    person.zipCode = Console.ReadLine();
                    Console.WriteLine("Enter your Phone Number:");
                    person.phoneNumber = Console.ReadLine();
                    Console.WriteLine("Enter your Email:");
                    person.email = Console.ReadLine();
                    people.Add(person);
                }
                contactDictionary.Add(addressBookName, people);
                n++;
            }
            Console.WriteLine("Enter Which addreeBook Detail you want to display");
            string addrees = Console.ReadLine();
            DisplayAdressBook(addrees);
            return people;
        }

        public void DisplayAllAdressBook()
        {
            foreach (KeyValuePair<string, List<Contact>> keyValue in contactDictionary)
            {
                Console.WriteLine("AddressBook Name:{0}", keyValue.Key);
                Console.WriteLine("\nDisplaying the person details\n");
                foreach (Contact contact in keyValue.Value)
                {
                    Console.WriteLine("First Name:" + contact.firstName);
                    Console.WriteLine("Last Name:" + contact.lastName);
                    Console.WriteLine("Adress:" + contact.address);
                    Console.WriteLine("City:" + contact.city);
                    Console.WriteLine("Zip Code:" + contact.zipCode);
                    Console.WriteLine("Phone Number:" + contact.phoneNumber);
                    Console.WriteLine("Email:" + contact.email);
                    Console.WriteLine("***************************************************");
                }
            }
        }

        // method for display contact details of adress book
        public void DisplayAdressBook(string addressBookName)
        {
            foreach (var key in contactDictionary.Keys)
            {
                if (key == addressBookName)
                {
                    foreach (var val in contactDictionary[key])
                    {
                        Console.WriteLine("Displaying the person details\n");
                        Console.WriteLine("First Name:" + val.firstName);
                        Console.WriteLine("Last Name:" + val.lastName);
                        Console.WriteLine("Adress:" + val.address);
                        Console.WriteLine("City:" + val.city);
                        Console.WriteLine("Zip Code:" + val.zipCode);
                        Console.WriteLine("Phone Number:" + val.phoneNumber);
                        Console.WriteLine("Email:" + val.email);
                        Console.WriteLine("***************************************************");
                    }
                }
            }

        }

        // Method for editing contact details
        public void EditContact()
        {
            Console.WriteLine("Enter the first name you want to edit information");
            string name = Convert.ToString(Console.ReadLine());
            bool input = false;
            Console.WriteLine("Enter: \n 1 for edit first name \n 2 for edit last name \n 3 for edit adress \n 4 for edit city \n 5 for edit zip code \n 6 for edit phone number \n 7 for edit email ");
            int option = Convert.ToInt32(Console.ReadLine());
            foreach (var person in people)
            {
                if (person.firstName == name) // if statement
                {
                    input = true;
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter Curent first name :");
                            string currentFirstName = Convert.ToString(Console.ReadLine());
                            person.firstName = currentFirstName;
                            break;
                        case 2:
                            Console.WriteLine("Enter Curent last name :");
                            string currentLastName = Convert.ToString(Console.ReadLine());
                            person.lastName = currentLastName;
                            break;
                        case 3:
                            Console.WriteLine("Enter Curent City Address :");
                            string currentAddress = Convert.ToString(Console.ReadLine());
                            person.address = currentAddress;
                            break;
                        case 4:
                            Console.WriteLine("Enter Curent City :");
                            string currentCity = Convert.ToString(Console.ReadLine());
                            person.city = currentCity;
                            break;
                        case 5:
                            Console.WriteLine("Enter Curent Zip Code :");
                            string currentZipCode = Convert.ToString(Console.ReadLine());
                            person.zipCode = currentZipCode;
                            break;
                        case 6:
                            Console.WriteLine("Enter Curent Phone Number :");
                            string currentPhoneNumber = Convert.ToString(Console.ReadLine());
                            person.phoneNumber = currentPhoneNumber;
                            break;
                        case 7:
                            Console.WriteLine("Enter Curent Email :");
                            string currentEmail = Convert.ToString(Console.ReadLine());
                            person.email = currentEmail;
                            break;
                        default:
                            Console.WriteLine("Please Enter valid Option");
                            break;
                    }

                }

            }
            if (input == false)
                Console.WriteLine("First name not found");
            
        }
        public void deleteContact()
        {   bool input = false;
            Console.WriteLine("enter the first name of contact you want to delete");
            string name = Convert.ToString(Console.ReadLine());
            foreach (var person1 in people)
            {
                if (person1.firstName == name) // if statement
                {
                    input = true;
                    people.Remove(person1); // for delting 
                    Console.WriteLine("adress book of person after remove");
                    break;
                }
            }
            if (input == false) // if statement
                Console.WriteLine("Contact not present");
        }
        public void AddNewAddressBook()
        {
            Console.WriteLine("How many number of address books you want to add ");
            int numberOfAdreBooks = Convert.ToInt32(Console.ReadLine());
            while (numberOfAdreBooks > 0)
            {
                Console.WriteLine("Enter name of the address book:");
                string addressBookName = Console.ReadLine();
                var listOfPeople= EntryDetails();
                contactDictionary.Add(addressBookName, listOfPeople);   // to store book name and contacts in dictionary
                Console.WriteLine("**{0}**\n",addressBookName);
                DisplayAdressBook(addressBookName); //to display contacts
                numberOfAdreBooks--;
            }
        }
    }
}
