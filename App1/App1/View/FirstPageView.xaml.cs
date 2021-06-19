using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstPageView : ContentPage
    {
        public FirstPageView()
        {
            InitializeComponent();
        }

        private async void Button1_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new SecondPageView());  // PushAsync(new SecondPageView());
        }
    }
}