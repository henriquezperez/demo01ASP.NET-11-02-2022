using demo01ASP.NET.Models;

namespace demo01ASP.NET.Services{

    public interface IOperaciones{
        
        Double Suma(Acciones acciones);
        Double Resta(Acciones acciones);
        Double Multiplicacion(Acciones acciones);
        Double Division(Acciones acciones);

    }
}