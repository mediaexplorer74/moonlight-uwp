using System;

namespace Moonlight
{
    internal class MoonlightConnectionListener
    {
        private Action<int> clStageStarting;
        private Action<int> clStageComplete;
        private Action<int, int> clStageFailed;
        private Action clConnectionStarted;
        private Action<int> clConnectionTerminated;
        private Action<string> clDisplayMessage;
        private Action<string> clDisplayTransientMessage;

        public MoonlightConnectionListener(Action<int> clStageStarting, Action<int> clStageComplete, Action<int, int> clStageFailed, Action clConnectionStarted, Action<int> clConnectionTerminated, Action<string> clDisplayMessage, Action<string> clDisplayTransientMessage)
        {
            this.clStageStarting = clStageStarting;
            this.clStageComplete = clStageComplete;
            this.clStageFailed = clStageFailed;
            this.clConnectionStarted = clConnectionStarted;
            this.clConnectionTerminated = clConnectionTerminated;
            this.clDisplayMessage = clDisplayMessage;
            this.clDisplayTransientMessage = clDisplayTransientMessage;
        }
    }
}