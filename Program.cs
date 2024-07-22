using POO_static.Models;

// Instanciar una clase.  Uso de propiedades y métodos
Console.Clear();
var ejemplo1 = new Ejemplo();
Console.WriteLine("Nombre=>" + ejemplo1.Nombre);
Console.WriteLine("Apellido=>" + ejemplo1.Apellido);
ejemplo1.Saludar();

// USO de propiedades y métodos pero con el STATIC
// EjemploEstatico.Nombre = "john";
// EjemploEstatico.Apellido = "Doe";
// Console.WriteLine("Nombre=>" + EjemploEstatico.Nombre);
// Console.WriteLine("Apellido=>" + EjemploEstatico.Apellido);
// EjemploEstatico.Saludar();


// USO DE UN CONSTRUCTOR STATIC

// EjemploEstatico.Saludar();

EjemploHibrido.MostrarHead();
var nuevoUsuario = new EjemploHibrido(1, "simon", " arias saldarriaga", 180);
nuevoUsuario.mostrarInformacion();
EjemploHibrido.MostrarFooter();