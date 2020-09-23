using System;
using Xamarin.Forms;
using FrisbeeAppi.Models;
using System.Linq;

namespace FrisbeeAppi
{
    public partial class GameEntryPage : ContentPage
    {
        public GameEntryPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            var game = (Game)BindingContext;

            var tracks = await App.Database.GetTracksAsync();
            var tracksListOrdered = tracks.OrderBy(a => a.Name).ToList();
            TrackPicker.ItemsSource = tracksListOrdered;

            if(game.TrackId > 0) {
              //haetaan tässä vielä varmuudeksi rataa tietokannasta, koska voi olla että game.TrackId on jonkun poistetun radan Id
              object selectedTrack = await App.Database.GetTrackAsync(game.TrackId);
              if(selectedTrack != null)
                TrackPicker.SelectedIndex = tracksListOrdered.FindIndex(a => a.ID == game.TrackId);
            }
        }

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var game = (Game)BindingContext;
            game.StartDateTime = DateTime.UtcNow;
            var selectedTrack = TrackPicker.SelectedItem as Track;
            if(selectedTrack != null) {
              game.TrackId = selectedTrack.ID;
            }
            await App.Database.SaveGameAsync(game);

            await Navigation.PopAsync();
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {

            var result = await this.DisplayAlert("Varmistus", "Haluatko varmasti poistaa tämän pelin?", "Kyllä", "Ei");

            if (!result)
            {
                return;
            }

            var game = (Game)BindingContext;

            await App.Database.DeleteGameAsync(game);

            await Navigation.PopAsync();
        }
    }
}
