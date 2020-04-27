using Jokes.Data;
using Jokes.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Jokes
{
    public partial class App : Application
    {
        static JokeDatabase database;
        public App()
        {
            InitializeComponent();
            var nav = new NavigationPage(new JokeListPage());

            MainPage = nav;
        }
        public static JokeDatabase Database
        {
            get
            {
                if(database == null)
                {
                    database = new JokeDatabase();
                }
                return database;
            }
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
