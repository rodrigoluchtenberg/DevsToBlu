
using System;
using System.Collections.Generic;

public abstract class InstrumentoMusical
{
    public abstract string Tocar();
}


public class Violao : InstrumentoMusical
{
    public override string Tocar()
    {
        return "tocando zezé de camargo no violão";
    }
}

public class Piano : InstrumentoMusical
{
    public override string Tocar()
    {
        return "tocando metallica no piano";
    }
}

public class Tambor : InstrumentoMusical
{
    public override string Tocar()
    {
        return "tocando um tambor no tambor";
    }
}


class Program
{
    static void Main()
    {
        InstrumentoMusical[] instrumentos = new InstrumentoMusical[]
        {
            new Violao(),
            new Piano(),
            new Tambor()
        };

        foreach (var instrumento in instrumentos)
        {
            Console.WriteLine(instrumento.Tocar());
        }
    }
}


