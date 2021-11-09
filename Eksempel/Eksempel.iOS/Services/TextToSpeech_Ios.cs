using AVFoundation;
using Eksempel.iOS.Services;
using Eksempel.Services;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(TextToSpeech_Ios))]
namespace Eksempel.iOS.Services
{
    class TextToSpeech_Ios : ITextToSpeech
    {
        public void Speak(string text)
        {
            var Synthesizer = new AVSpeechSynthesizer();

            var utterance = new AVSpeechUtterance(text)
            {
                Rate = AVSpeechUtterance.MaximumSpeechRate / 4,
                Voice = AVSpeechSynthesisVoice.FromLanguage("en-US"),
                Volume = 0.5f,
                PitchMultiplier = 1.0f
            };

            Synthesizer.SpeakUtterance(utterance);
        }
    }
}