using System;
using System.Collections.Generic;
using System.Text;

namespace Eksempel.Services
{
    public interface ITextToSpeech
    {
        void Speak(string text);
    }
}
