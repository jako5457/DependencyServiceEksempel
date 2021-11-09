using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Speech.Tts;
using Android.Views;
using Android.Widget;
using Eksempel.Droid.Services;
using Eksempel.Services;
using Java.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(TextToSpeech_Android))]
namespace Eksempel.Droid.Services
{
    public class TextToSpeech_Android : Java.Lang.Object, ITextToSpeech, TextToSpeech.IOnInitListener
    {
        TextToSpeech speaker;
        string toSpeak;

        public void Speak(string text)
        {

            var ctx = Android.App.Application.Context;
            toSpeak = text;

            if (speaker == null)
            {
                speaker = new TextToSpeech(ctx, this);
            }
            else
            {
                speaker.Speak(toSpeak, QueueMode.Flush,null,null);
            }
        }

        public void OnInit([GeneratedEnum] OperationResult status)
        {
            if (status.Equals(OperationResult.Success))
            {
                speaker.Speak(toSpeak, QueueMode.Flush,null,null);
            }
        }
    }
}