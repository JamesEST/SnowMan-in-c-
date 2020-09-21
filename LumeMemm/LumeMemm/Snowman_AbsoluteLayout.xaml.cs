using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LumeMemm
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Snowman_AbsoluteLayout : ContentPage
    {
        int klick = 0;
        public Snowman_AbsoluteLayout()
        {
            InitializeComponent();
        }
        
        private void ButtonOn_OnClicked(object sender, EventArgs e)
        {
            klick++;

            if (klick % 2 == 0)
            {
                ButtonOn.Text = "Включить";
                One.Opacity = 0;
                Two.Opacity = 0;
                Three.Opacity = 0;

            }

            else
            {
                ButtonOn.Text = "Выключить";
                One.Opacity = 100;
                Two.Opacity = 100;
                Three.Opacity = 100;
            }
        }
    }
}