using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //AddressEntry[] addressEntry = new AddressEntry[n];
            //AddressEntry entry = new AddressEntry();

            Console.Write("Въведи размера на адресната книга: ");
            int n = int.Parse(Console.ReadLine()); //size
            AddressBook addressBook = new AddressBook(n);
            while (true)
            {
                Console.WriteLine("Избери команда:");
                Console.WriteLine("1 - Add entry");
                Console.WriteLine("2 - Delete entry");
                Console.WriteLine("3 - Insert entry");
                Console.WriteLine("4 - Print entries");
                Console.WriteLine("5 - Exit");
                
                int command = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (command)
                {
                    case 1:
                        Console.Write("Въведи име: ");
                        string name = Console.ReadLine();
                        Console.Write("Въведи адрес: ");
                        string address = Console.ReadLine();
                        Console.Write("Въведи любими номера(rating): ");
                        int rating = int.Parse(Console.ReadLine());
                        addressBook.AddEntry(name, address, rating);
                        break;
                    case 2:
                        Console.WriteLine("Въведи ID за да се изтриее записа(entry):"); 
                        int deleteId = int.Parse(Console.ReadLine());
                        addressBook.DeleteEntry(deleteId);
                        break;
                    case 3:
                        Console.Write("Въведи ID за да се вмъкне след това: ");
                        int insertId = int.Parse(Console.ReadLine());
                        Console.Write("Въведи име: ");
                        string insertName = Console.ReadLine();
                        Console.Write("Въведи адрес: ");
                        string insertAddress = Console.ReadLine();
                        Console.Write("Въведи любими номера(rating): ");
                        int insertRating = int.Parse(Console.ReadLine());
                        addressBook.InsertEntry(insertId, insertName, insertAddress, insertRating);
                        break;
                    case 4:
                        addressBook.PrintAll();
                        break;
                    case 5:
                        return;
                }
                Console.WriteLine();
            }
        }
    }
}

