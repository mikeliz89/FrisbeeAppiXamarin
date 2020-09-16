using FrisbeeAppi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xamarin.Forms;

namespace FrisbeeAppi
{
    public partial class MainPage : ContentPage
    {
        //string _fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "notes.txt");

        public MainPage()
        {
            InitializeComponent();

            /*
            if (File.Exists(_fileName))
            {
                editor.Text = File.ReadAllText(_fileName);
            }
            */
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var games = new List<Game>();

            var gameFiles = Directory.EnumerateFiles(App.FolderPath, "*.games.txt");
            foreach (var filename in gameFiles)
            {
                games.Add(new Game
                {
                    StartDateTime = File.GetCreationTime(filename),
                    EndDateTime = System.DateTime.Now,
                    Description = "",
                    Players = new List<Player>(),
                    Track = new Track(),
                    //Tallennusta varten:
                    Filename = filename,
                    Text = File.ReadAllText(filename)
                });
            }

            listView.ItemsSource = games
                .OrderBy(d => d.StartDateTime).Reverse()
                .ToList();
        }

        async void OnGameAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GameEntryPage
            {
                BindingContext = new Game()
            });
        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new GameEntryPage
                {
                    BindingContext = e.SelectedItem as Game
                });
            }
        }

        /*

        void OnMiikaButtonClicked(object sender, EventArgs e)
        {
            editor.Text = "Valmis teksti napin takaa";
        }

        void OnSaveButtonClicked(object sender, EventArgs e)
        {
            File.WriteAllText(_fileName, editor.Text);
        }

        void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            if (File.Exists(_fileName))
            {
                File.Delete(_fileName);
            }
            editor.Text = string.Empty;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
        */
    }
}