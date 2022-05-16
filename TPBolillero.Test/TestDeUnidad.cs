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
        [Fact]
        public void SacarBolillaTest()
        {
            // Given
            
            // When
        
            // Then
        }
    }
}
