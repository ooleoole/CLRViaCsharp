using System;
using System.Collections.Generic;
using System.Text;

namespace CLRViaCsharp.CharEncoding
{
    public sealed class StringEncoder
    {
        private Encoding _encoder = new UTF8Encoding();

        

        public byte[] Encoder(string input)
        {
            return _encoder.GetBytes(input);
        }

        public string Decoder(byte[] input)
        {
            return _encoder.GetString(input);
        }
    }
}
