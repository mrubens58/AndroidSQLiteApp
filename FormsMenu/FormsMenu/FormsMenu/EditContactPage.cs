using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FormsMenu
{
    public class EditContactPage : ContentPage
    {
        private ContactListApp _parent;
        private ContactDatabase _database;

        Contact contact = ContactListApp._contactList.SelectedItem as Contact;

        public EditContactPage(ContactListApp parent, ContactDatabase database)
        {
            _parent = parent;
            _database = database;
            Title = "Edit a Contact";


            var fname = new Entry()
            {
                Text = contact.FirstName
            };

            var lname = new Entry()
            {
                Text = contact.LastName
            };

            var ct = new Entry()
            {
                Text = contact.ContactType
            };


            var button = new Button
            {
                Text = "Save"
            };

            var del = new Button
            {
                Text = "Delete"
            };

            var can = new Button
            {
                Text = "Cancel"
            };

            button.Clicked += async (object sender, EventArgs e) =>
            {
                var i = contact.ID;

                _database.DeleteContact(i);

                var firstname = fname.Text;
                var lastname = lname.Text;
                var ctype = ct.Text;

                _database.AddContact(firstname, lastname, ctype);

                await Navigation.PopAsync();


                _parent.Refresh();
            };

            del.Clicked += async (object sender, EventArgs e) =>
            {
                var i = contact.ID;

                _database.DeleteContact(i);

                await Navigation.PopAsync();


                _parent.Refresh();
            };

            can.Clicked += async (object sender, EventArgs e) =>
            {
                await Navigation.PopAsync();
            };

            Content = new StackLayout
            {
                Spacing = 20,
                Padding = new Thickness(20),
                Children = { fname, lname, ct, button, del, can },
            };





        }
    }
}
