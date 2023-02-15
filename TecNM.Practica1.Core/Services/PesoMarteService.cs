using TecNM.Practica1.Core.Entities;
using TecNM.Practica1.Core.Services.Interfaces;

namespace TecNM.Practica1.Core.Services;

public class PesoMarteService : IPesoMarteService{

    public PesoMarte ProcessPesoEnMarte(Person person){
        var pesoMarte = new PesoMarte();

        pesoMarte.PesoEnMarte = (person.Peso / 9.81f) * 3.711f;

        return pesoMarte;
    }










}