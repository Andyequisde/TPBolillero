using System;
using System.Collections.Generic;

namespace TPBolillero.Core
{
    public class Primero : IAzar
    {
        public byte SacarBolilla(List<byte> bolillas )
        {
            return Convert.ToByte(bolillas[0]);
        }
    }
}