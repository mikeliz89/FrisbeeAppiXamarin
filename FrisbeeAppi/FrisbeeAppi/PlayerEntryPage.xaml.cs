using System;
using Xamarin.Forms;
using FrisbeeAppi.Models;

namespace FrisbeeAppi
{
    public partial class PlayerEntryPage : ContentPage
    {
        public PlayerEntryPage()
        {
            InitializeComponent();
        }

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var player = (Player)BindingContext;
            player.Created = DateTime.UtcNow;
            await App.Database.SavePlayerAsync(player);

            await Navigation.PopAsync();
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var result = await this.DisplayAlert("Varmistus", "Haluatko varmasti poistaa tämän pelaajan?", "Kyllä", "Ei");

            if (!result)
            {
                return;
            }

            var player = (Player)BindingContext;

            await App.Database.DeletePlayerAsync(player);

            await Navigation.PopAsync();
        }
    }
}
