using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_static.Models;

public static class EjemploEstatico
{
    public static string Nombre { get; set; }
    public static string Apellido { get; set; }

    static EjemploEstatico()
    {
        Nombre = "John";
        Apellido = "Doe";
    }

    public static void Saludar()  // LA PALABRA RESERVADA "VOID" INDICA QUE NO RETORNA NADA
    {
        Console.WriteLine($"hola a todos soy {Nombre} {Apellido}");
    }

}

// NOTA: SI LAS CLASES SON STATIC, NO ES NECESARIO INSTANCIAR LAS CLASES, PERO SON MAS RESTRICTIVAS EN COMPARACIÓN A LAS CLASES CLASICAS