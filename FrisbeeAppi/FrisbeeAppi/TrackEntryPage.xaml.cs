using System;
using Xamarin.Forms;
using FrisbeeAppi.Models;

namespace FrisbeeAppi
{
    public partial class TrackEntryPage : ContentPage
    {
        public TrackEntryPage()
        {
            InitializeComponent();
        }

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var track = (Track)BindingContext;
            track.Created = DateTime.UtcNow;
            await App.Database.SaveTrackAsync(track);

            await Navigation.PopAsync();
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {

            var result = await this.DisplayAlert("Varmistus", "Haluatko varmasti poistaa tämän radan?", "Kyllä", "Ei");

            if (!result)
            {
                return;
            }

            var track = (Track)BindingContext;

            await App.Database.DeleteTrackAsync(track);

            await Navigation.PopAsync();
        }
    }
}
