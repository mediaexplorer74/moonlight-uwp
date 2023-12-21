using System;

namespace Moonlight
{
    public class MoonlightStreamConfiguration
    {
        private int v1;
        private int v2;
        private int v3;
        private int v4;
        private int v5;
        private byte[] aesKey;
        private byte[] aesIv;

        public MoonlightStreamConfiguration(int v1, int v2, int v3, int v4, int v5, byte[] aesKey, byte[] aesIv)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
            this.aesKey = aesKey;
            this.aesIv = aesIv;
        }

        public uint GetHeight()
        {
            throw new NotImplementedException();
        }

        public uint GetWidth()
        {
            throw new NotImplementedException();
        }

        internal uint GetBitrate()
        {
            throw new NotImplementedException();
        }

        internal string GetFps()
        {
            throw new NotImplementedException();
        }

        internal byte[] GetRiAesIv()
        {
            throw new NotImplementedException();
        }

        internal byte[] GetRiAesKey()
        {
            throw new NotImplementedException();
        }
    }
}