using FrisbeeAppi.Models;
using System;
using Xamarin.Forms;

namespace FrisbeeAppi
{
    public partial class ListTracks : ContentPage
    {
        public ListTracks()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            listView.ItemsSource = await App.Database.GetTracksAsync();
        }

        async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async void OnTrackAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TrackEntryPage
            {
                BindingContext = new Track()
            } );
        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new TrackEntryPage
                {
                    BindingContext = e.SelectedItem as Track
                });
            }
        }
    }
}