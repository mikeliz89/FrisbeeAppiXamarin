using System;
using System.IO;
using Xamarin.Forms;
using FrisbeeAppi.Models;

namespace FrisbeeAppi
{
    public partial class GameEntryPage : ContentPage
    {
        public GameEntryPage()
        {
            InitializeComponent();
        }

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var game = (Game)BindingContext;

            if (string.IsNullOrWhiteSpace(game.Filename))
            {
                // Save
                var filename = Path.Combine(App.FolderPath, $"{Path.GetRandomFileName()}.games.txt");
                File.WriteAllText(filename, game.Text);
            }
            else
            {
                // Update 
                File.WriteAllText(game.Filename, game.Text);
            }

            await Navigation.PopAsync();
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var game = (Game)BindingContext;

            if (File.Exists(game.Filename))
            {
                File.Delete(game.Filename);
            }

            await Navigation.PopAsync();
        }
    }
}
