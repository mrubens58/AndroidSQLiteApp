using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;
using System.IO;



namespace FormsMenu
{
    public class ContactListApp : ContentPage
    {
        private ContactDatabase _database;
        public static ListView _contactList;


        public ContactListApp ()
        {
            
            _database = new ContactDatabase();
            Title = "Contacts";
            //var contacts = _database.GetContacts();

            _contactList = new ListView()
            {
                ItemTemplate = new DataTemplate(() =>
                {

                    TextCell cell = new TextCell()
                    {
                        Command = new Command(() => Navigation.PushAsync(new EditContactPage(this, _database)))
                    };
                    cell.SetBinding(TextCell.TextProperty, "FullName");
                    cell.SetBinding(TextCell.DetailProperty, "ContactType");
                    return cell;

                })
            };
            _contactList.ItemsSource = _database.GetContacts();
            //_contactList.ItemTemplate = new DataTemplate(typeof(TextCell));
            //_contactList.ItemTemplate.SetBinding(TextCell.TextProperty, "FullName");
            //_contactList.ItemTemplate.SetBinding(TextCell.DetailProperty, "ContactType");

            var toolbarItem = new ToolbarItem
            {
                Text = "Add",
                Command = new Command(() => Navigation.PushAsync(new NewContactPage(this, _database)))
            };

            ToolbarItems.Add(toolbarItem);

            Content = _contactList;
            
        }

        public void Refresh()
        {
            _contactList.ItemsSource = _database.GetContacts();
        }

             
    }
}
