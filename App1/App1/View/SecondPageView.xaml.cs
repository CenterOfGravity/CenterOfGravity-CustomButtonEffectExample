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
    public partial class SecondPageView : ContentPage
    {
        public SecondPageView()
        {
            InitializeComponent();
        }

        //private async void ButtonRegresar_Clicked(object sender, EventArgs e)
        //{
        //    //    await Application.Current.MainPage.Navigation.PushModalAsync(new FirstPageView());
        //    await Application.Current.MainPage.Navigation.PopModalAsync();
        //}

        bool TimerIsRunning;
        System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
        private void ButtonRegresar_Pressed(object sender, EventArgs e)
        {
            stopwatch.Restart();
            TimerIsRunning = true;
            int increment = 1;
            Device.StartTimer(TimeSpan.FromMilliseconds(300), () =>
            {
                counter.Text = (Convert.ToInt32(counter.Text) + increment).ToString();

                return TimerIsRunning;
            });
        }

        private void ButtonRegresar_Released(object sender, EventArgs e)
        {
            TimerIsRunning = false;
            stopwatch.Stop();
        }
    }
}