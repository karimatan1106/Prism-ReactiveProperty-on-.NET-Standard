using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Reactive.Bindings;

namespace NET_Standard.ViewModels
{
    public class MainPageViewModel : INavigationAware
    {
        public ReactiveProperty<string> Title { get; set; }

        public MainPageViewModel()
        {
            Title = new ReactiveProperty<string>("Prism & ReactiveProperty");
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }
    }
}