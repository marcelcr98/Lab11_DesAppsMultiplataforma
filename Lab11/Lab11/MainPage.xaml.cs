using Lab11.ModelViews;
using Lab11.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab11
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Item11.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new SimpleDemo());
            };
            Item12.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new InteractiveDemo());
            };
            Item13.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new CommandDemo());
            };
            Item14.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Operaciones());
            };
        }
    }
}
