using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FormsMenu
{
    public class FormsMenuPage : ContentPage
    {
        public FormsMenuPage()
        {
            Command<Type> pageCommand =
                new Command<Type>(async (Type pageType) =>
                {
                    Page page = (Page)Activator.CreateInstance(pageType);
                    await Navigation.PushAsync(page);
                });

            Title = "Forms Menu";

            Content = new TableView
            {
                Intent = TableIntent.Menu,
                Root = new TableRoot
                {
                    new TableSection("Class Project Apps") {

                        //new TextCell
                        //{
                        //    Text="Slider and Switch App",
                        //    Command=pageCommand,
                        //    CommandParameter=typeof(SliderSwitchApp),
                        //},

                        //new TextCell
                        //{
                        //    Text="StopWatch App",
                        //    Command=pageCommand,
                        //    CommandParameter=typeof(StopWatchApp),
                        //},

                        new TextCell
                        {
                            Text="Contact List",
                            Command=pageCommand,
                            CommandParameter=typeof(ContactListApp),
                        }

                    },
                                        
                    new TableSection("Views for Presentation")
                    {
                        //new TextCell
                        //{
                        //    Text="Label Demo",
                        //    Command=pageCommand,
                        //    CommandParameter=typeof(LabelDemoPage),
                        //},

                        //new TextCell
                        //{
                        //    Text="Box View Demo",
                        //    Command=pageCommand,
                        //    CommandParameter=typeof(BoxViewDemoPage),
                        //},

                        //new TextCell
                        //{
                        //    Text="Local Image",
                        //    Command=pageCommand,
                        //    CommandParameter=typeof(LocalImagePage),
                        //},

                        //new TextCell
                        //{
                        //    Text="Download Image",
                        //    Command=pageCommand,
                        //    CommandParameter=typeof(DownloadImagePage),
                        //},

                        //new TextCell
                        //{
                        //    Text="Web Page",
                        //    Command=pageCommand,
                        //    CommandParameter=typeof(WebpagePage),
                        //}
                    },
                    
                    new TableSection("Views that Initiate Commands"),
                    new TableSection("Views for Common Data Types")
                    {
                        //new TextCell
                        //{
                        //    Text="Web Page",
                        //    Command=pageCommand,
                        //    CommandParameter=typeof(WebpagePage),
                        //}                        
                    },
                    new TableSection("Views for Editing Text"),
                    new TableSection("Views to Indicate Activity"),
                    new TableSection("Views that Display Collections"),

                    new TableSection("Layouts with Single Content")
                    {
                        //new TextCell
                        //{
                        //    Text="Date and Time Picker",
                        //    Command=pageCommand,
                        //    CommandParameter=typeof(DateTimePicker),
                        //},

                        //new TextCell
                        //{
                        //    Text="Scroll View Demo",
                        //    Command=pageCommand,
                        //    CommandParameter=typeof(ScrollViewDemoPage),
                        //}
                    },                    

                    new TableSection("Layouts with Multiple Children")
                    {
                        //new TextCell
                        //{
                        //    Text="StackLayout Demo",
                        //    Command=pageCommand,
                        //    CommandParameter=typeof(StackLayoutDemoPage),
                        //}
                    },
                    new TableSection("Pages")
                    {
                        //new TextCell
                        //{
                        //    Text="ContentPage Demo",
                        //    Command=pageCommand,
                        //    CommandParameter=typeof(ContentDemoPage),
                        //},

                        //new TextCell
                        //{
                        //    Text="NavigationPage Demo",
                        //    Command=pageCommand,
                        //    CommandParameter=typeof(NavigationDemoPage),
                        //},

                        //new TextCell
                        //{
                        //    Text="Tabbed Page",
                        //    Command=pageCommand,
                        //    CommandParameter=typeof(TabbedDemoPage),
                        //},

                        //new TextCell
                        //{
                        //    Text="Carousel Page",
                        //    Command=pageCommand,
                        //    CommandParameter=typeof(CarouselPageDemo),
                        //}
                    },

                }

            };
        }
    }
}
