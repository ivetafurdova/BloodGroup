using Plugin.ExternalMaps;
using Plugin.ExternalMaps.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace BloodGroup
{
    public partial class MainPage : ContentPage
    {
        private Pin selectedPin;
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            MainMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(42.020857, 23.094339),
                Distance.FromKilometers(5)));
            var pin = new Pin
            {
                Position = new Position(42.023419, 23.090386),
                Label = "МБАЛ - Благоевград АД",
                Address = "ул.Славянска № 60 "
            };
            var pin2 = new Pin
            {
                Position = new Position(42.6843986, 23.304074600000035),
                Label = "ВMA - София",
                Address = "бул.Св.Георги Софийски № 3"
            };
            var pin3 = new Pin
            {
                Position = new Position(42.7085401, 23.3202986),
                Label = "НЦТХ София",
                Address = "ул.Бр.Миладинови №112"
            };
            var pin4 = new Pin
            {
                Position = new Position(42.6605934, 23.371926700000017),
                Label = "УМБАЛ Св.Анна - София",
                Address = "София, ж.к.Младост 1, ул.Димитър Моллов № 1"
            };
            var pin5 = new Pin
            {
                Position = new Position(42.2800924, 22.700474100000065),
                Label = "МБАЛ Св. Иван Рилски - Кюстендил",
                Address = "пл. 17 януари № 1"
            };
            pin.Clicked += Pin_Clicked;
            pin2.Clicked += Pin_Clicked;
            pin3.Clicked += Pin_Clicked;
            pin4.Clicked += Pin_Clicked;
            pin5.Clicked += Pin_Clicked;

            MainMap.Pins.Add(pin);
            MainMap.Pins.Add(pin2);
            MainMap.Pins.Add(pin3);
            MainMap.Pins.Add(pin4);
            MainMap.Pins.Add(pin5);




        }

        private void Pin_Clicked(object sender, EventArgs evenArgs)
        {

            selectedPin = sender as Pin;

            DisplayAlert(selectedPin?.Label, selectedPin?.Address, "OK");
        }

        private void GetDirections_Clicked(object sender, EventArgs e)
        {
            CrossExternalMaps.Current.NavigateTo(
                selectedPin.Label,
                selectedPin.Position.Latitude,
                selectedPin.Position.Longitude,
                NavigationType.Driving);
        }
    }
}
