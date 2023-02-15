using System;
using TecNM.Practica1.Core.Entities;
using TecNM.Practica1.Core.Managers;
using TecNM.Practica1.Core.Services;

namespace TecNM.Practica1.App;

public static class Program{
    public static void Main(string [] args){

        float peso = 0;

        System.Console.WriteLine("Please enter your weight: ");
        Single.TryParse(System.Console.ReadLine(), out peso);

        var person = new Person(){Peso = peso};
        var service = new PesoMarteService();
        var manager = new PesoMarteManager(service);

        PesoMarte pesoMarte = manager.GetPesoEnMarte(person);

        System.Console.WriteLine($"Tu peso en Marte es de {pesoMarte.PesoEnMarte}");

    }

}