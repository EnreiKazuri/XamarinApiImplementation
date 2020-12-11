using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using XamarinAPIImplementation.Models;
using XamarinAPIImplementation.Services;

namespace XamarinAPIImplementation.ViewModels
{
    class HomeViewModel : INotifyPropertyChanged
    {
        public ICommand GetRandomPlatformCommand => new Command(GetRandomPlatform);
        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));

        public event PropertyChangedEventHandler PropertyChanged;
        public Result Platform 
            { get; set; }

        async void GetRandomPlatform()
        {
            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                IPlatformListApiService apiService = new PlatformListApiService();
                Platform = await apiService.GetPlatform();
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Error", "Check your internet connection and try again", "Ok");
            }
        }
    }
}
