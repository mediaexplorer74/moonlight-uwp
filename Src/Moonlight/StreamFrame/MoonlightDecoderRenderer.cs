using System;

namespace Moonlight
{
    internal class MoonlightDecoderRenderer
    {
        private Action<int, int, int, int> drSetup;
        private Action drCleanup;
        private Func<byte[], int> drSubmitDecodeUnit;

        public MoonlightDecoderRenderer(Action<int, int, int, int> drSetup, Action drCleanup, Func<byte[], int> drSubmitDecodeUnit)
        {
            this.drSetup = drSetup;
            this.drCleanup = drCleanup;
            this.drSubmitDecodeUnit = drSubmitDecodeUnit;
        }
    }
}