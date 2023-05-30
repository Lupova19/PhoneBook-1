using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal class AddressBook
    {
        private AddressEntry[] entries;
        public AddressBook(int n)
        {
            entries = new AddressEntry[n];
        }
        public void AddEntry(string name, string address, int rating)
        {
            for (int i = 0; i < entries.Length; i++)
            {
                if (entries[i] == null)
                {
                    AddressEntry entry = new AddressEntry(name, address, rating);
                    entries[i] = entry;
                    Console.WriteLine("Записът е добавен успешно!");
                    return;
                }

            }
            Console.WriteLine("Адресната книга е пълна и записът не е добавен!");
        }
        public void DeleteEntry(int id)
        {
            if (id >= 1 && id <= entries.Length)
            {
                entries[id - 1] = null;
                Console.WriteLine($"Записът(entry) ID {id} e изтрит успешно!");
            }
            else
            {
                Console.WriteLine($"Записът(entry) ID {id} не съществува!");
            }
        }
        public void InsertEntry(int id, string name, string address, int rating)
        {
            if (id >= 1 && id <= entries.Length)
            {
                if (entries[id - 1] == null)
                {
                    AddressEntry entry = new AddressEntry(name, address, rating);
                    entries[id - 1] = entry;
                    Console.WriteLine("Записът(entry) е вмъкнат успешно!");
                }
                else
                {
                    Console.WriteLine($"Вече има запис(entry) на ID!");
                }
            }
            else
            {
                Console.WriteLine($"Не може да се вмъкне запис(entry) в ID!");
            }
        }
        public void PrintAll()
        {
            for (int i = 0; i < entries.Length; i++)
            {
                if (entries[i] != null)
                {
                    Console.WriteLine($"ID:{i + 1}");
                    entries[i].Print();
                }
            }
        }

    }
}
