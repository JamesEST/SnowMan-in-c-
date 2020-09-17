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
        Frame onee, twoo, threee;
        Label oneee;
        Button btn3, btn4;
        Switch switcher;
        Stepper Stepper;
        bool switcherrr;
        double tempp;


        public MainPage()
        {
            //InitializeComponent();
        
            //Создание Frame
            onee = new Frame()
            {
                HeightRequest = 20,
                WidthRequest = 20,
                BackgroundColor = Color.White,
                CornerRadius = 90,
                Padding = 80,
                HorizontalOptions = LayoutOptions.Center,
                Opacity = 0
            };

            twoo = new Frame()
            {
                HeightRequest = 40,
                WidthRequest = 40,
                BackgroundColor = Color.White,
                CornerRadius = 110,
                Padding = 80,
                HorizontalOptions = LayoutOptions.Center,
                Opacity = 0
            };

            threee = new Frame()
            {
                HeightRequest = 60,
                WidthRequest = 60,
                BackgroundColor = Color.White,
                CornerRadius = 130,
                Padding = 80,
                HorizontalOptions = LayoutOptions.Center,
                Opacity = 0
            };
            //Создание label
            oneee = new Label()
            {
                
            };

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
                HorizontalOptions = LayoutOptions.Start,
                Increment = 1,
                Maximum = 20,
                Minimum = 0,
                Opacity = 0
                

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
                Children = { onee, twoo, threee, stackLayout2, stackLayout1, oneee }

            };
            stackLayout2.Orientation = StackOrientation.Horizontal;
            stackLayout2.Margin = new Thickness(0, 0, 0, 0);

            Content = stackLayout;

            btn3.Clicked += Btn3_Clicked;
            btn4.Clicked += Btn4_Clicked;
            switcher.Toggled += Switcher_Toggled;
            Stepper.ValueChanged += Stepper_ValueChanged;
        }


        private async void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            tempp = e.NewValue;

            if(switcherrr == true)
            {
                oneee.Text = String.Format("Temp:{0:F1}℃", e.NewValue);
                if (tempp >= 1)
                {
                    switcher.Opacity = 0;
                    for (int i = 0; i < 1; i++)
                    {

                        onee.Opacity = 0.8;
                        twoo.Opacity = 0.8;
                        threee.Opacity = 0.8;
                        await Task.Run(() => Thread.Sleep(1000));
                        onee.Opacity = 0.6;
                        twoo.Opacity = 0.6;
                        threee.Opacity = 0.6;
                        await Task.Run(() => Thread.Sleep(1000));
                        onee.Opacity = 0.4;
                        twoo.Opacity = 0.4;
                        threee.Opacity = 0.4;
                        await Task.Run(() => Thread.Sleep(1000));
                        onee.Opacity = 0.2;
                        twoo.Opacity = 0.2;
                        threee.Opacity = 0.2;
                        await Task.Run(() => Thread.Sleep(1000));
                        onee.Opacity = 0;
                        twoo.Opacity = 0;
                        threee.Opacity = 0;

                    }
                }
                else if (tempp >= 4)
                {
                    for (int i = 0; i < 1; i++)
                    {

                        onee.Opacity = 0.8;
                        twoo.Opacity = 0.8;
                        threee.Opacity = 0.8;
                        await Task.Run(() => Thread.Sleep(500));

                        onee.Opacity = 0.4;
                        twoo.Opacity = 0.4;
                        threee.Opacity = 0.4;
                        await Task.Run(() => Thread.Sleep(500));

                        onee.Opacity = 0;
                        twoo.Opacity = 0;
                        threee.Opacity = 0;
                    }
                }
               switcher.Opacity = 100;
            }   
        }

        private async void Btn4_Clicked(object sender, EventArgs e)
        {
            if (switcherrr == true)
            {
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
            else if (switcherrr == false)
            {
                await DisplayAlert("Уведомление", "Снеговик выключен, сначало включи его", "ОK");
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
                Stepper.Opacity = 100;
            
            }
     
            else if (e.Value == false)
            {
                onee.Opacity = 0;
                twoo.Opacity = 0;
                threee.Opacity = 0;
                Stepper.Opacity = 0;
             

                onee.BackgroundColor = Color.White;
                twoo.BackgroundColor = Color.White;
                threee.BackgroundColor = Color.White;

                Stepper.Value = 0;
                oneee.Text = "";
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
    }
}
