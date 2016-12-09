using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;

namespace FormsMenu
{
    public class ContactDatabase
    {
        private SQLiteConnection _connection;

        public ContactDatabase()
        {
            _connection = DependencyService.Get<ISQLite>().GetConnection();
            _connection.CreateTable<Contact>();

            if (_connection.Table<Contact>().Count() == 0)
            {
                // only insert the data if it doesn't already exist
                var newContact = new Contact();

                newContact.FirstName = "Michael";
                newContact.LastName = "Rubenstein";
                newContact.ContactType = "Student";
                _connection.Insert(newContact);
                
                newContact.FirstName = "David";
                newContact.LastName = "Blain";
                newContact.ContactType = "Magician";
                _connection.Insert(newContact);


            }
        }

        //public IEnumerable<Contact> GetContacts()
        //{
        //    return (from t in _connection.Table<Contact> ()
        //            select t).ToList ();
        //}
        public IEnumerable<Contact> GetContacts()
        {
            return _connection.Query<Contact>("SELECT * FROM Contacts ORDER BY LastName, FirstName");
                    
        }

        public Contact GetContact(int id)
        {
            return _connection.Table<Contact>().FirstOrDefault(t => t.ID == id);
        }

        public void DeleteContact(int id)
        {
            _connection.Delete<Contact>(id);
        }

        public void AddContact(string firstname, string lastname, string ctype)
        {
            var newContact = new Contact
            {
                FirstName = firstname,
                LastName = lastname,
                ContactType = ctype
            };

            _connection.Insert(newContact);
        }
    }
}
