using System;
namespace Hospital
{
    public class CInterfaz
    {
        public CInterfaz()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
        }
        public string darOpcion()
        {
            Console.Clear();
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Sistema de Gestión de Profesionales Especialistas *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("\n[E] Establecer bono por especialidad.");
            Console.WriteLine("\n[A] Agregar un especialista.");
            Console.WriteLine("\n[M] Mostrar datos de un especialista.");
            Console.WriteLine("\n[R] Remover un especialista.");
            Console.WriteLine("\n[S] Salir de la aplicación.");
            Console.WriteLine("\n****************************************************");
            return this.pedirDato("opción elegida");
        }
        public string pedirDato(string nombDato)
        {
            Console.Write("[?] Ingrese " + nombDato + ": ");
            string ingreso = Console.ReadLine();
            while (ingreso == "")
            {
                Console.Write("[!] " + nombDato + "es de ingreso OBLIGATORIO:");
                ingreso = Console.ReadLine();
            }
            Console.Clear();
            return ingreso.Trim();
            //.Trim() Remueve espacios en blanco previos y posteriores.

        }
        public void mostrarInfo(string mensaje)
        {
            Console.WriteLine(mensaje);
            Console.Write("<Pulse Enter>");
            Console.ReadLine();
            Console.Clear();
        }
    }
}

