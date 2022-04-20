using System;
using System.Collections.Generic;

namespace TPBolillero.Core
{
    public class Aleatorio : IAzar
    {
        private Random Random{ get; set; }
        public byte SacarBolilla(List<byte> bolillas )
        {
            var a = bolillas.Count;
            var b = Random.Next(0,a);
            return Convert.ToByte(bolillas[b]);
        }
    }
}