using Eksempel.Services;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Eksempel.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(() => DependencyService.Get<ITextToSpeech>().Speak("Hello from xamarin forms"));
        }

        public ICommand OpenWebCommand { get; }
    }
}