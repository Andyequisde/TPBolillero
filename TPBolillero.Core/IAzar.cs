using System.Collections.Generic;

namespace TPBolillero.Core
{
    public interface IAzar
    {
        public byte SacarBolilla(List<byte> bolillas);
    }
}