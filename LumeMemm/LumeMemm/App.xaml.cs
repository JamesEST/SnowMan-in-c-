using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LumeMemm
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Snowman_AbsoluteLayout();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
