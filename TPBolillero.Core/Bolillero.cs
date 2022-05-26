using System;
using System.Collections.Generic;

namespace TPBolillero.Core
{
    public class Bolillero
    {   
        public List<byte> Adentro { get; set; }
        public List<byte> Afuera { get; set; }
        public IAzar Azar { get; set; }

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
        public Bolillero(byte cantBolillas): this()
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
        /*cuando saco una bolilla sea igual a mi 
        lista y que devuelva verdadero */
        public bool Jugar(List<byte> cantBolillas)
        {
            for(int i = 0; i < cantBolillas.Count ; i++)
            {
                if(SacarBolilla() != cantBolillas[i])
                return false;
            }
            return true;
        }

        /*Este bolillero también admite jugarNVeces, recibiendo por parámetro una lista de bolillas y
        una cantidad de veces a jugar, devolviendo la cantidad de veces que la lista de bolillas fue acertada.
        También se debe de poder volver a colocar en el bolillero, las bolillas sacadas.*/

        public long JugarNVeces(List<byte> cantBolillas , int Cantidad)
        {
            long Contador = 0;
            for (int i = 0; i < Cantidad ; i++)
            {
                if (Jugar(cantBolillas))
                {
                    Contador++;
                }
            }
            return Contador; 
        }
    } 
}
