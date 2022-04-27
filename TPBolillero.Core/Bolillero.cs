using System;
using System.Collections.Generic;

namespace TPBolillero.Core
{
    public class Bolillero
    {   
        public List<byte> Adentro { get; set; }
        public List<byte> Afuera { get; set; }
        private IAzar Azar { get; set; }

        public Bolillero()
        {
            Adentro = new List<byte>();
            Afuera = new List<byte>();
        }
        private void CrearBolillas(byte cantBolillas)
        {
            for(byte i = 0; i < cantBolillas ; i++)
            {
                Adentro.Add(i);
            }
        }
        private void CrearBolillero(byte cantBolillas)
        {
            CrearBolillas(cantBolillas);
        }
        public byte SacarBolilla()
        {
            var a = Azar.SacarBolilla(Adentro);
            Adentro.Remove(a);
            Afuera.Add(a);
            return(a);
        }
        
        public void ReIngresar()
        {   
            Adentro.AddRange(Afuera);
            Afuera.Clear();
        }
        //cuando saco una bolilla sea igual a mi 
        //lista xd y que devuelva verdadero 
        public bool Jugar(List<byte> cantBolillas)
        {
            for(int i = 0; i < cantBolillas.Count ; i++)
            {
                if(SacarBolilla() != cantBolillas[i])
                return false;
            }
            return true;
        }

        //public long JugarN(List<Byte>)
    } 
}
