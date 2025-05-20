using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LED_Autocorrelator
{
    internal class ProgramLogic
    {
        public struct ApplicationSettings
        {
            private bool _keepApplicationLog;

            public bool KeepApplicationLog
            {
                get { return _keepApplicationLog; }
                set { _keepApplicationLog = value; }
            }
        }
    }
}
