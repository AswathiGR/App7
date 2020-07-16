using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App7
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void choose(object sender, EventArgs e)
        {

            if (stack.IsVisible == true)
            {
                stack.IsVisible = false;
                Downarrow.RotateTo(0);
            }
            else
            {
                stack.IsVisible = true;
                Downarrow.RotateTo(180);

            }

        }
        private void tdy(object sender, EventArgs e)
        {
            Option.Text = "Today";
            Option.TextColor = Color.FromHex("#000000");
        }

        private void Tomorrow(object sender, EventArgs e)
        {
            Option.Text = "Tomorrow";
            Option.TextColor = Color.FromHex("#000000");
        }
        private void Past(object sender, EventArgs e)
        {
            Option.Text = "Yesterday";
            Option.TextColor = Color.FromHex("#000000");
        }

    }

}