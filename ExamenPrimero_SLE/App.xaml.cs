using ExamenPrimero_SLE.Vista;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenPrimero_SLE
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Principal();
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
