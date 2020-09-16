using System;
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
            game.StartDateTime = DateTime.UtcNow;
            await App.Database.SaveGameAsync(game);

            await Navigation.PopAsync();
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var game = (Game)BindingContext;

            await App.Database.DeleteGameAsync(game);

            await Navigation.PopAsync();
        }
    }
}
