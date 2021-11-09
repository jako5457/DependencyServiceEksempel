using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyServiceEksempel.Services
{
    public interface ISpeakService
    {
        void speak(string text, int speed = 1, int pitch = 1, string locale = null);
    }
}
