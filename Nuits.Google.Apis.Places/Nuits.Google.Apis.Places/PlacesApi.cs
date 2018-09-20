using System;
using System.Net.Http;

namespace Nuits.Google.Apis.Places
{
    public class PlacesApi
    {
        public PlacesApi(string appSecret)
        {
            AppSecret = appSecret;
        }

        private static HttpClient Client { get; } = new HttpClient { BaseAddress = new Uri("https://maps.googleapis.com/maps/api/place/") };

        private string AppSecret { get; }

        public void NearbySearchAsync()
        {
            var uri = $"https://maps.googleapis.com/maps/api/place/nearbysearch/json?location=35.681167,139.767052&radius=1500&type=restaurant&key={AppSecret}";
        }

    }
}
