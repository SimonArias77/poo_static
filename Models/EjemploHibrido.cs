using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_static.Models;

public class EjemploHibrido
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public byte AlturaEnCM { get; set; }

    public static DateTime FechaActual = DateTime.Now;

    public EjemploHibrido(int id, string nombre, string apellido, byte alturaEnCM)
    {
        Id = id;
        Nombre = nombre;
        Apellido = apellido;
        AlturaEnCM = alturaEnCM;
    }

    public void mostrarInformacion()
    {
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Apellido: {Apellido}");
        Console.WriteLine($"AlturaEnCM:{AlturaEnCM}");
    }

    public static void MostrarHead()
    {
        Console.WriteLine("######################");
        Console.WriteLine("      Detalles        ");
        Console.WriteLine("######################");
    }

    public static void MostrarFooter()
    {
        Console.WriteLine("-----------------------");
    }
}

// PROPIEDADES:  a veces representadas como una llave o comoun ladrillo azul
// MÉTODOS: son los cubitos morados