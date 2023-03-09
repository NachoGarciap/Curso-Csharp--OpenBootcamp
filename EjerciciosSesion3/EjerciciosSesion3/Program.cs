using System;
class Program
{
    static void Main(string[] args)
    {
        //instanciamos el objeto cliente
        Cliente Cliente = new Cliente();
        Console.Write("Escribe tu nombre completo: ");
        Cliente.nombreCompleto = Console.ReadLine();

        Console.Write("Escribe tu telefono: ");
        Cliente.telefono = Console.ReadLine();

        Console.Write("Escribe tu direccion: ");
        Cliente.direccion = Console.ReadLine();

        Console.Write("Escribe tu email: ");
        Cliente.email = Console.ReadLine();

        Cliente.nuevoCliente = true;//true= si, false =no
        

        Console.WriteLine("");
        Cliente.MostrarDatos();
    }
}

//Estructura cliente
struct Cliente
{
    //campos
    public string nombreCompleto;
    public string telefono;
    public string direccion;
    public string email;
    public bool nuevoCliente; //true= si, false =no

    //Metodo Mostrar datos
    public void MostrarDatos()
    {
        Console.WriteLine($"Nombre completo: " +nombreCompleto);
        Console.WriteLine($"Teléfono: "+ telefono);
        Console.WriteLine($"Dirección: "+direccion);
        Console.WriteLine($"Email: "+email);
        Console.WriteLine($"¿Es nuevo cliente? (si/no): "+nuevoCliente);
    }
}


