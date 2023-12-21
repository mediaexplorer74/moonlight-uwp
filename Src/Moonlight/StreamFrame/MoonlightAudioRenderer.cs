using System;

namespace Moonlight
{
    internal class MoonlightAudioRenderer
    {
        private Action arInit;
        private Action arCleanup;
        private Action<byte[]> arPlaySample;

        public MoonlightAudioRenderer(Action arInit, Action arCleanup, Action<byte[]> arPlaySample)
        {
            this.arInit = arInit;
            this.arCleanup = arCleanup;
            this.arPlaySample = arPlaySample;
        }
    }
}