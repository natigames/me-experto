using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace experto
{
    public partial class App : Application
    {
        public static string DatabaseLocation = string.Empty;

        public App()
        {
            // used to initialize Tabbed pages
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }

        // used for sqlite
        public App(string databaseLocation)
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
            DatabaseLocation = databaseLocation;
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
