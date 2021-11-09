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

namespace DependencyServiceEksempel.Droid.Services
{
    public class SpeakService_Android : Java.Lang.Object, ISpeakService, TextToSpeech.IOnInitListener
    {
        TextToSpeech speaker;
        string toSpeak;

        public SpeakService_Android()
        {
            
        }

        public void OnInit([GeneratedEnum] OperationResult status)
        {
            if (status.Equals(OperationResult.Success))
            {
                var p = new Dictionary<string, string>();
                speaker.Speak(toSpeak, QueueMode.Flush, p);
            }
        }

        public void speak(string text,int speed = 1,int pitch = 1, string locale = null)
        {
            toSpeak = text;
            if (speaker == null)
            {
                speaker = new TextToSpeech(Application.Context, this);
                if (locale == null)
                {
                    speaker.SetLanguage(Locale.Default);
                }
                else
                {
                    var SelectedLocale = Locale.ForLanguageTag(locale);
                    if (locale != null)
                    {
                        speaker.SetLanguage(SelectedLocale);
                    }
                    else
                    {
                        speaker.SetLanguage(Locale.Default);
                    }
                }

                speaker.SetPitch(pitch);
                speaker.SetSpeechRate(speed);
            }
            else
            {
                var p = new Dictionary<string, string>();
                speaker.Speak(toSpeak, QueueMode.Flush, p);
            }
        }
    }
}