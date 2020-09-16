using FrisbeeAppi.Models;
using System;
using Xamarin.Forms;

namespace FrisbeeAppi
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            listView.ItemsSource = await App.Database.GetGamesAsync();
        }

        async void OnNavigateToTracksListClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListTracks
            {
               
            } );
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
    }
}