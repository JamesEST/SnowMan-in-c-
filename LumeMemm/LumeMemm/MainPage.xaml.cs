using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace LumeMemm
{
    public partial class MainPage : ContentPage
    {
        private Random rnd = new Random();
        Button btn1, btn2, btn3, btn4;
        Label one, two, three;
        Frame onee, twoo, threee;
        Switch switcher;
        bool switcherrr;
        Stepper Stepper;


        public MainPage()
        {
            //InitializeComponent();

            //Создание label
            one = new Label()
            {

                TextColor = Color.White,
                FontSize = 15,
                FontAttributes = FontAttributes.Bold
            };

            onee = new Frame()
            {
                HeightRequest = 20,
                WidthRequest = 20,
                BackgroundColor = Color.White,
                Content = one,
                CornerRadius = 90,
                Padding = 80,
                HorizontalOptions = LayoutOptions.Center,
                Opacity = 0

            };

            two = new Label()
            {

                TextColor = Color.White,
                FontSize = 15,
                FontAttributes = FontAttributes.Bold
            };

            twoo = new Frame()
            {
                HeightRequest = 40,
                WidthRequest = 40,
                BackgroundColor = Color.White,
                Content = one,
                CornerRadius = 110,
                Padding = 80,
                HorizontalOptions = LayoutOptions.Center,
                Opacity = 0
            };

            three = new Label()
            {

                TextColor = Color.White,
                FontSize = 15,
                FontAttributes = FontAttributes.Bold
            };

            threee = new Frame()
            {
                HeightRequest = 60,
                WidthRequest = 60,
                BackgroundColor = Color.White,
                Content = one,
                CornerRadius = 130,
                Padding = 80,
                HorizontalOptions = LayoutOptions.Center,
                Opacity = 0
            };

            //Создание кнопок
           // btn1 = new Button()
           //{
           //     HorizontalOptions = LayoutOptions.Start,
           //     Text = "ON",

           // };
           // btn2 = new Button()
           // {
           //     HorizontalOptions = LayoutOptions.End,
           //     Text = "OFF",

           // };
            btn3 = new Button()
            {
                HorizontalOptions = LayoutOptions.End,
                Text = "Random",
            };
            btn4 = new Button()
            {
                HorizontalOptions = LayoutOptions.Start,
                Text = "Bye",
            };
            switcher = new Switch
            {
                IsToggled = false,
                HorizontalOptions = LayoutOptions.Center,
                
            };
            Stepper = new Stepper
            {
                HorizontalOptions = LayoutOptions.Start
            };



            StackLayout stackLayout2 = new StackLayout()
            {
                Children = { btn4, Stepper, btn3 }
            };
            StackLayout stackLayout1 = new StackLayout()
            {
                Children = { switcher }
            };
            StackLayout stackLayout = new StackLayout()
            {
                Children = { onee, twoo, threee, stackLayout2, stackLayout1 }

            };
            stackLayout2.Orientation = StackOrientation.Horizontal;
            stackLayout2.Margin = new Thickness(0, 0, 0, 0);

            Content = stackLayout;

            
            //btn1.Clicked += Btn1_Clicked;
           // btn2.Clicked += Btn2_Clicked;
            btn3.Clicked += Btn3_Clicked;
            btn4.Clicked += Btn4_Clicked;
            switcher.Toggled += Switcher_Toggled;



        }

        private async void Btn4_Clicked(object sender, EventArgs e)
        {
            Console.WriteLine(onee.Opacity);
            for (int i = 0; i < 1; i++)
            {
                
                onee.Opacity = 0.8;
                twoo.Opacity = 0.8;
                threee.Opacity = 0.8;
                await Task.Run(() => Thread.Sleep(100));
                onee.Opacity = 0.5;
                twoo.Opacity = 0.5;
                threee.Opacity = 0.5;
                await Task.Run(() => Thread.Sleep(100));
                onee.Opacity = 0.2;
                twoo.Opacity = 0.2;
                threee.Opacity = 0.2;
                await Task.Run(() => Thread.Sleep(100));
                onee.Opacity = 0;
                twoo.Opacity = 0;
                threee.Opacity = 0;






            }
        }

        private void Switcher_Toggled(object sender, ToggledEventArgs e)
        {
            switcherrr = e.Value;

            if (e.Value == true)
            {
                onee.Opacity = 100;
                twoo.Opacity = 100;
                threee.Opacity = 100;
            }
     
            else if (e.Value == false)
            {
                onee.Opacity = 0;
                twoo.Opacity = 0;
                threee.Opacity = 0;

                onee.BackgroundColor = Color.White;
                twoo.BackgroundColor = Color.White;
                threee.BackgroundColor = Color.White;

            }
        }

        private void Btn3_Clicked(object sender, EventArgs e)
        {
            if (switcherrr == true)
            {
                Color randomColor = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                onee.BackgroundColor = randomColor;

                Color randomColor1 = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                twoo.BackgroundColor = randomColor1;

                Color randomColor2 = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                threee.BackgroundColor = randomColor2;
            }
            else if (switcherrr == false)
            {
                DisplayAlert("Уведомление", "Снеговик выключен", "ОK");
            }



        }

        private void Btn2_Clicked(object sender, EventArgs e)
        {
            
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
          
        }
    }
}
