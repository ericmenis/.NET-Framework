using System;
namespace Banca
{
    public static class CInterfaz
    {
        static CInterfaz()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public static string darOpcion()
        {
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("*        Sistema de Gestión de Cuentas        *");
            Console.WriteLine("***********************************************");
            Console.WriteLine("\n[G] Establecer gastos mensuales.");
            Console.WriteLine("\n[A] Agregar una cuenta.");
            Console.WriteLine("\n[D] Efectuar un depósito.");
            Console.WriteLine("\n[E] Efectuar una extracción.");
            Console.WriteLine("\n[M] Mostrar datos de una cuenta.");
            Console.WriteLine("\n[L] Listar los datos de todas las cuentas.");
            Console.WriteLine("\n[R] Remover una cuenta.");
            Console.WriteLine("\n[S] Salir de la aplicación.");
            Console.WriteLine("\n**********************************************");
            return CInterfaz.pedirDato("opción elegida");
        }
        public static string pedirDato(string nombDato)
        {
            Console.Write("[?] Ingrese " + nombDato + ": ");
            string ingreso = Console.ReadLine();
            while (ingreso == "")
            {
                Console.Write("[!] " + nombDato + " es de ingreso OBLIGATORIO:");
                ingreso = Console.ReadLine();
            }
            Console.Clear();
            return ingreso.Trim();
            //.Trim() Remueve espacios en blanco previos y posteriores.

        }
        public static void mostrarInfo(string mensaje)
        {
            Console.WriteLine(mensaje);
            Console.Write("<Pulse Enter>");
            Console.ReadLine();
            Console.Clear();
        }
    }
}

