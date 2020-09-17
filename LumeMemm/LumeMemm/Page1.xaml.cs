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
    public partial class Page1 : ContentPage

    {
        int klick = 0;
        public Page1()
        {
            InitializeComponent();
        }

        private void Btn_Clicked(object sender, EventArgs e)
        {
            klick++;

            if (klick % 2 == 0)
            {
                btn.Text = "Включить";
                one.Opacity = 0;
                two.Opacity = 0;
                three.Opacity = 0;

            }

            else
            {
                btn.Text = "Выключить";
                one.Opacity = 100;
                two.Opacity = 100;
                three.Opacity = 100;
            }


        }
    }
}