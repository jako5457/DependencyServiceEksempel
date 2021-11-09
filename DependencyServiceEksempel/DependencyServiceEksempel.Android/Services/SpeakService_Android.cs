using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DependencyServiceEksempel.Droid.Services;
using DependencyServiceEksempel.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Android.Speech.Tts;
using Java.Util;

[assembly: Dependency(nameof(SpeakService_Android),LoadHint.Always)]
namespace DependencyServiceEksempel.Droid.Services
{
    public class SpeakService_Android : ISpeakService
    {

        public SpeakService_Android()
        {
            
        }

        public void speak(string text,Locale locale = null,int speed = 1,int pitch = 1)
        {
            TextToSpeech tts = new TextToSpeech(Application.Context,this);

            if (locale == null)
            {
                tts.SetLanguage(Locale.Default);
            }
            else
            {
                tts.SetLanguage(locale);
            }

            tts.SetPitch(pitch);
            tts.SetSpeechRate(speed);
            var p = new Dictionary<string, string>();
            tts.Speak(text, QueueMode.Flush, p);

        }
    }
}