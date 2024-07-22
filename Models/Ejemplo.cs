using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_static.Models;

public class Ejemplo
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }

    public Ejemplo()
    {
        Nombre = "John";
        Apellido = "Doe";
    }

    public void Saludar()  // LA PALABRA RESERVADA "VOID" INDICA QUE NO RETORNA NADA
    {
        Console.WriteLine($"hola a todos soy {Nombre} {Apellido}");
    }

}
