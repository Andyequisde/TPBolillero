using System;
using TPBolillero.Core;
using Xunit;

namespace TPBolillero.Test
{
    public class TestDeUnidad
    {
        public Bolillero Bolillero { get; set; }
        
        [Fact]
        
        public void BolilleroTest()
        {
            Bolillero = new Bolillero(10);
            Bolillero.Azar = new Primero();
        }
        public void SacarBolillaTest()
        {
            //Verificar que devuelve la bolilla 0 (cero).
            
            //verificar que dentro del bolillero hay 9 bolillas.

            //Verificar que afuera del bolillero hay una bolilla.

        }
    }
}
