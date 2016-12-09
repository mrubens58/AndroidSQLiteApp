using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;
using SQLite;

namespace FormsMenu
{
    [Table("Contacts")]
    public class Contact
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string ContactType { set; get; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public Contact()
        {
            
        }

        
                
    }
}
