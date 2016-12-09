using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FormsMenu
{

    public class NewContactPage : ContentPage
    {
        private ContactListApp _parent;
        private ContactDatabase _database;

       
        public NewContactPage(ContactListApp parent, ContactDatabase database)
        {
            
            _parent = parent;
            _database = database;
            Title = "Enter a Contact";
                        

            var fname = new Entry()
            {
                Placeholder = "First Name"
            };

            var lname = new Entry()
            {
                Placeholder = "Last Name"
            };

            var ct = new Entry()
            {
                Placeholder = "Contact Type"
            };


            var button = new Button
            {
                Text = "Add"
            };

            button.Clicked += async (object sender, EventArgs e) =>
            {
                var firstname = fname.Text;
                var lastname = lname.Text;
                var ctype = ct.Text;

                _database.AddContact(firstname, lastname, ctype);

                await Navigation.PopAsync();


                _parent.Refresh();
            };

            Content = new StackLayout
            {
                Spacing = 20,
                Padding = new Thickness(20),
                Children = { fname, lname, ct, button },
            };
        }
            
    }
}
