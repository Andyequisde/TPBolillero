using System;
using System.Collections.Generic;
using TPBolillero.Core;
using Xunit;

namespace TPBolillero.Test
{
    public class TestDeUnidad
    {
        public Bolillero Bolillero { get; set; }
        public TestDeUnidad()
        {
            Bolillero = new Bolillero(10);
            Bolillero.Azar = new Primero();
        }
        [Fact]
        public void SacarBolillaTest()
        {
            //Verificar que devuelve la bolilla 0 (cero).
            //verificar que dentro del bolillero hay 9 bolillas.
            //Verificar que afuera del bolillero hay una bolilla.
            var bolilla = Bolillero.SacarBolilla();
            var cantBolillasDentro = Bolillero.Adentro.Count;
            Assert.Equal(9, cantBolillasDentro);
            Assert.Equal(0, bolilla);
            Assert.Single(Bolillero.Afuera);
        }

        //Test method ReIngresar: Se tiene que sacar una bolilla y después correr el método de reingresar bolillas.
        [Fact]
        public void ReIngresarTest()
        {
            //Verificar que dentro del bolillero hay 10 bolillas.
            Bolillero.SacarBolilla();
            Bolillero.ReIngresar();
            var cantBolillasDentro = Bolillero.Adentro.Count;
            Assert.Equal(10, cantBolillasDentro);
            //Verificar que fuera del bolillero no hay ninguna bolilla.
            Assert.Empty(Bolillero.Afuera);
        }

        //Test method JugarGana: Se tiene que jugar con {0,1,2,3} y verificar que se ganó en todos los casos, EJEMPLOS.
        [Fact]
        public void JugarGana()
        {
            List<byte> lista = new List<byte> {0,1,2,3};
            Assert.True(Bolillero.Jugar(lista));
        }

        //Test method JugarPierde: Se tiene que jugar con {4, 2, 1} y verificar que no se ganó.
        [Fact]
        public void JugarPierde()
        {
            List<byte> lista2 = new List<byte>{4, 2, 1};
            Assert.False(Bolillero.Jugar(lista2));
        }

        //Test method GanarNVeces: con la jugada {0, 1} se tiene que jugar 1 vez y verificar que se ganó 1 vez
        [Fact]
        public void GanarNVecesTest()
        {
            List<byte> lista3 = new List<byte>{0, 1};
            Assert.Equal(1, Bolillero.JugarNVeces(lista3 , 1));
        }
    }
}
