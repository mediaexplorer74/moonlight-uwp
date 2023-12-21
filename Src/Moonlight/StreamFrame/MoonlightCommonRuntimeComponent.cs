using System;

namespace Moonlight
{
    internal class MoonlightCommonRuntimeComponent
    {
        internal static void SendControllerInput(short controllerIndex, int v1, int v2, int v3, int v4, int v5, int v6)
        {
            throw new NotImplementedException();
        }

        internal static void SendKeyboardEvent(short key, byte up, byte v)
        {
            throw new NotImplementedException();
        }

        internal static void SendMouseButtonEvent(byte press, int left)
        {
            throw new NotImplementedException();
        }

        internal static void SendMouseMoveEvent(short xToSend, short yToSend)
        {
            throw new NotImplementedException();
        }

        internal static void SendMultiControllerInput(short controllerIndex, short buttonFlags, byte leftTrigger, byte rightTrigger, short leftThumbX, short leftThumbY, short rightThumbX, short rightThumbY)
        {
            throw new NotImplementedException();
        }

        internal static void SendScrollEvent(short v)
        {
            throw new NotImplementedException();
        }

        internal static void StartConnection(string serverIp, MoonlightStreamConfiguration streamConfig, MoonlightConnectionListener clCallbacks, MoonlightDecoderRenderer drCallbacks, MoonlightAudioRenderer arCallbacks, int serverMajorVersion)
        {
            throw new NotImplementedException();
        }

        internal static void StopConnection()
        {
            throw new NotImplementedException();
        }
    }
}