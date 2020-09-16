using FrisbeeAppi.Data;
using System;
using System.IO;
using Xamarin.Forms;

namespace FrisbeeAppi
{
    public partial class App : Application
    {
        public static string FolderPath { get; private set; }

        static GameDatabase database;

        public static GameDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new GameDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Games.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();
            FolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
