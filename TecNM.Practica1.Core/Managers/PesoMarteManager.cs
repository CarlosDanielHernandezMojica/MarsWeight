using TecNM.Practica1.Core.Entities;
using TecNM.Practica1.Core.Managers.Interfaces;
using TecNM.Practica1.Core.Services.Interfaces;

namespace TecNM.Practica1.Core.Managers;

public class PesoMarteManager : IPesoMarteManager{

    private readonly IPesoMarteService _service;

    public PesoMarteManager(IPesoMarteService service){
        _service = service;
    }

    public PesoMarte GetPesoEnMarte(Person person){
        return _service.ProcessPesoEnMarte(person);
    }

}