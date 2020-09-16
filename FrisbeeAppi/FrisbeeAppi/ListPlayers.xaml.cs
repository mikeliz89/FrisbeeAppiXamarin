using FrisbeeAppi.Models;
using System;
using Xamarin.Forms;

namespace FrisbeeAppi
{
    public partial class ListPlayers : ContentPage
    {
        public ListPlayers()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            listView.ItemsSource = await App.Database.GetPlayersAsync();
        }

        async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async void OnPlayerAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PlayerEntryPage
            {
                BindingContext = new Player()
            } );
        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new PlayerEntryPage
                {
                    BindingContext = e.SelectedItem as Player
                });
            }
        }
    }
}