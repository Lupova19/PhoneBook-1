using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal class AddressEntry
    {
        private int id;
        private string name;
        private string address;
        private string phoneNumber;
        private int rating;
        private List<AddressEntry> addresses; 

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }
        public AddressEntry(int id, string name, string address, string phoneNumber, int rating)
        {
            addresses = new List<AddressEntry>(); 
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.rating = rating;
        }
        public AddressEntry(string name, string phoneNumber)
        {
            this.Name = name; 
            this.phoneNumber = phoneNumber;
            Random random = new Random();
            this.PhoneNumber = "0" + random.Next(100000000, 999999999).ToString();

        }
        public AddressEntry()
        {
            this.Name = null; 
            this.Address = null;
            this.PhoneNumber = null;
            this.Rating = 0;
        }

        public AddressEntry(string name, string phoneNumber, int rating) : this(name, phoneNumber)
        {
        }

        public void Print()
        {
            Console.WriteLine(this.Id);    
            Console.WriteLine(this.Name);
            Console.WriteLine(this.Address);
            Console.WriteLine(this.PhoneNumber);
            Console.WriteLine(this.Rating);
        }
       
    }
}
