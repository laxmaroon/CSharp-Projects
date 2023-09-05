using System;
using System.Collections.Generic;

public class Contact
{
    public string Name { get; set; } 
    public string PhoneNumber { get; set; }
}

public class TelephoneDirectory
{
    private List<Contact> contacts;
    public TelephoneDirectory()
    {
        contacts = new List<Contact>();
    }
    public void AddContact(string name, string phoneNumber)
    {
        Contact contact = new Contact
        {
            Name = name,
            PhoneNumber = phoneNumber
        };
        contacts.Add(contact);  
    }
    public void RemoveContact(string name)
    {
        Contact contactToRemove = contacts.Find(Contact => Contact.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (contactToRemove!=null)
        {
            {
                contacts.Remove(contactToRemove);
            }
        }

    }
    public void PrintDirectory()
    {
        Console.WriteLine("Telephone Directory:");
        foreach( var contact in contacts)
        {
            Console.WriteLine($"Name: {contact.Name}\t Phone Number:{contact.PhoneNumber}");

        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        TelephoneDirectory directory = new TelephoneDirectory();
        while (true)
        {
            Console.WriteLine("Enter an option");
            Console.WriteLine("1. Add a contact");
            Console.WriteLine("2. Remove a contact");
            Console.WriteLine("3. Print directory");
            Console.WriteLine("4. Exit");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter the contact name:");
                    string name = Console.ReadLine();

                    Console.WriteLine("Enter the phone number");
                    string phoneNumber = Console.ReadLine();

                    directory.AddContact(name, phoneNumber);
                    Console.WriteLine("Contact added succesfully!");
                    Console.WriteLine();
                    break;

                case 2:
                    Console.WriteLine("Enter the contact name to remove:");
                    string contactName = Console.ReadLine();

                    directory.RemoveContact(contactName);
                    Console.WriteLine("Contact removed succesfully!");
                    Console.WriteLine();
                    break;

                case 3:
                    directory.PrintDirectory();
                    Console.WriteLine();
                    break;

                case 4:
                    return;

                default:
                    Console.WriteLine("Invalid option please try again");
                    Console.WriteLine();
                    break;
            }
        }
    } 
}


