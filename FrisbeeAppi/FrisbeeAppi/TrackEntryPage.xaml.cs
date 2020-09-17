using System;
using Xamarin.Forms;
using FrisbeeAppi.Models;
using System.Collections.ObjectModel;

namespace FrisbeeAppi
{
    public partial class TrackEntryPage : ContentPage
    {
        ObservableCollection<Hole> holes = new ObservableCollection<Hole>();

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

        async void OnCreateHolesButtonClicked(object sender, EventArgs e)
        {
            /*
             *  Tällä funktiolla olisi tarkoitus luoda uuden radan väylät kenttään annetun väylämäärän perusteella.
             *  Todo: Koodaa väylien tietokantaosio joko eri sivulle tai sitten erillisenä toimintona.
             */
            var track = (Track)BindingContext;
            var trackHoleCount = track.HolesCount;
            var maxHoleCount = 36; /* todo: lue väylien maksimimäärä jostain tietokannasta/tiedostosta */

            if (trackHoleCount <= 0)
            {
                await this.DisplayAlert("Epäonnistui", "Anna numero", "OK");
                return;
            }
            else if(trackHoleCount > maxHoleCount)
            {
                await this.DisplayAlert("Epäonnistui", "Väylien maksimimäärä on " + maxHoleCount, "OK");
                return;
            }

            var listHoleCount = holes.Count;
            var missingHoles = trackHoleCount - listHoleCount;

            if(missingHoles > 0)
            {
                for (int i = 0; i < missingHoles; i++)
                {
                    var number = listHoleCount + 1;
                    var hole = new Hole
                    {
                        Par = 3,
                        Length = 100,
                        Number = number
                    };
                    holes.Add(hole);
                    listHoleCount++;
                }
            } 
            else if (missingHoles == 0) 
            {
                await this.DisplayAlert("Epäonnistui", "Väylät luotu jo", "OK");
            }
            else if (missingHoles < 0)
            {
                var removedHolesCount = -missingHoles; //muuta negatiivinen luku positiiviseksi
                for (int i = 0; i < removedHolesCount; i++) {
                    holes.RemoveAt(listHoleCount - 1);
                    listHoleCount--;
                }
            }

            listViewHoles.ItemsSource = holes;
        }

        void OnListViewItemSelected(object sender, EventArgs e) { }
    }
}
