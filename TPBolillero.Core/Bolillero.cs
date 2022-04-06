using System;
using System.Collections.Generic;

namespace TPBolillero.Core;

public class Bolillero
{   
    public List<byte> Adentro { get; set; }
    public List<byte> Afuera { get; set; }
    private IAzar azar;

    public Bolillero()
    {
        Adentro = new List<byte>();
        Afuera = new List<byte>();
    }
    public Bolillero(byte Bolillas)
    {
        
    }
    private void CrearBolillero(byte)
    {

    }
    public void ReIngresar()
    {
        
    }
    public byte SacarBolilla();
    

    
    public bool Jugar(List<byte>) 
    {

    }
    public long JugarN(List<Byte>)
    {

    }
    
}   
