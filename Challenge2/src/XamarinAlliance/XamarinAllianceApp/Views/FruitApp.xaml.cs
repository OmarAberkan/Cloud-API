using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinAllianceApp.Models;

namespace XamarinAllianceApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FruitApp : ContentPage
    {

     
        public FruitApp()
        {
            InitializeComponent();




            Label header = new Label
            {
                Text = "FruitApp",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };

            TableView tableView = new TableView
            {
                Intent = TableIntent.Form,
                Root = new TableRoot
                {
                    new TableSection
                    {



                        new ImageCell
                        {

                            // Some differences with loading images in initial release.
                          
                            Text = "Apple",
                            Detail = "The apple tree is a deciduous tree in the rose family best known for its sweet, pomaceous fruit, the apple.",
                        },
                          new ImageCell
                        {

                         
                            Text = "Banana",
                            Detail = "The banana is an edible fruit – botanically a berry – produced by several kinds of large herbaceous flowering plants in the genus Musa. ",
                        },
                            new ImageCell
                        {

                           
                            Text = "Strawberry",
                            Detail = "The garden strawberry is a widely grown hybrid species of the genus Fragaria.",
                        },
                              new ImageCell
                        {

                            
                            Text = "Berry",
                            Detail = "In everyday language, a berry is a small, pulpy, and often edible fruit. ",
                          
                        },

                    }

                }

            };

            Button button = new Button
            {
                Text = "Read more about Apples!",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                TextColor=Color.Green,
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Button button1 = new Button
            {
                Text = "Read more about Bananas!",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                TextColor = Color.Yellow,
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Button button2 = new Button
            {
                Text = "Read more about Strawberries!",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                TextColor = Color.Red,
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Button button3 = new Button
            {
                Text = "Read more about Berries!",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                TextColor=Color.Black,
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            button.Clicked += Button_Clicked;
            button1.Clicked += Button_Clicked1;
            button2.Clicked += Button_Clicked2;
            button3.Clicked += Button_Clicked3;


            // Accomodate iPhone status bar.
            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

            // Build the page.
            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    tableView,
                    button,
                    button1,
                    button2,
                    button3
                }
            };
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Appel());
        }
        private void Button_Clicked1(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Banaan());
        }
        private void Button_Clicked2(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Aardbei());
        }
        private void Button_Clicked3(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Bes());
        }
        void OnNextPageButtonClicked(object sender, EventArgs e, Page pagina)
        {
            
        }
    }
}

