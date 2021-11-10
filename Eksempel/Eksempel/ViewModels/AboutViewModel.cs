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
            SpeakCommand = new Command(() => DependencyService.Get<ITextToSpeech>().Speak("Start developing now. Make changes to your XAML file and save to see your UI update in the running app with XAML Hot Reload. Give it a try! Learn more at https://aka.ms/xamarin-quickstart"));
        }

        public ICommand SpeakCommand { get; }
    }
}