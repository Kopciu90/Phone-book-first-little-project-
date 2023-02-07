using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_book
{
    internal class PhoneBook
    {
        public List<Contact> Contacts { get; set; }

        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }

        public void DisplayContact(string number)
        {
            var contact = Contacts.FirstOrDefault(x => x.Number == number);
        }
    }
}
