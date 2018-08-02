using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamlSamples
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Button button = new Button
            {
                Text = "Navigate!",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            button.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new HelloXamlPage());
            };

            //Content = button;

            Button button2 = new Button
            {
                Text = "XAMLPlusCode!",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            button2.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new XamlPlusCodePage());
            };

            Content = button2;

            Button button3 = new Button
            {
                Text = "GridDemoPage!",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            button3.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new GridDemoPage());
            };

            Content = button3;

            Button button4 = new Button
            {
                Text = "AbsoluteDemoPage!",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            button4.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new AbsoluteDemoPage());
            };

            Content = button4;
        }
    }
}
