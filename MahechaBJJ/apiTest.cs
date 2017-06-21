using System;
using System.Collections.Generic;
using System.Net.Http;
using MahechaBJJ.Model;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace MahechaBJJ
{
    public class apiTest : ContentPage
    {
        private HttpClient test = new HttpClient();

        public apiTest()
        {
            var button = new Button
            {
                Text = "Click me to test api!"
            };
            //event
            button.Clicked += TestApiCall;

            var stackLayout = new StackLayout
            {
                Children = {
                    button
                }
            };

            Content = stackLayout;
        }

        private async void TestApiCall(object sender, EventArgs e)
        {
            var json = await test.GetStringAsync("http://localhost:8080/showAll");
            List<apiTestModel>jsonConvert = JsonConvert.DeserializeObject<apiTestModel>(json);
            foreach (var item in jsonConvert)
            {
                jsonConvert.Add(item);
            }
            await DisplayAlert("output", jsonConvert[0].title, "works!");
        }
    }
}

