using System;
namespace Hospital
{
    public class CControladora
    {
        public static void Main(String[] args)
        {
            CCartilla cartilla = new CCartilla();
            CInterfaz interfaz = new CInterfaz();
            char opcion;
            uint auxMat;
            string auxNombApe;
            do
            {
                opcion = Convert.ToChar(interfaz.darOpcion().ToUpper());
                //.ToUpper() Convierte la cadena a MAYÚSCULAS.
                switch (opcion)
                {
                    case 'E':
                        float auxPorcentaje = Convert.ToSingle(interfaz.pedirDato("Porcentaje adicional por especialidad"));
                        CEspecialista.setBono(auxPorcentaje);
                        //Lo correcto sería que CCartilla tenga un método setBono()
                        break;
                    case 'A':
                        auxMat = Convert.ToUInt32(interfaz.pedirDato("Matrícula"));
                        auxNombApe = interfaz.pedirDato("Nombres y Apellidos");
                        float auxMonto= Convert.ToSingle(interfaz.pedirDato("Honorarios"));
                        bool auxBalcon = Convert.ToBoolean(interfaz.pedirDato("¿Admite realizar guardias?[true-false]"));
                        if (!cartilla.registrar(auxMat, auxNombApe,auxMonto,auxBalcon ))
                        {
                            interfaz.mostrarInfo("Especialista Preexistente");
                        }
                        break;
                    case 'M':
                        auxMat = Convert.ToUInt32(interfaz.pedirDato("Matrícula"));
                        interfaz.mostrarInfo(cartilla.darDatos(auxMat));
                        break;
                    case 'R':
                        auxMat = Convert.ToUInt32(interfaz.pedirDato("Matrícula"));
                        if (!cartilla.remover(auxMat))
                        {
                            interfaz.mostrarInfo("Especialista Inexistente");
                        }
                        break;
                    case 'S':
                        break;
                    default:
                        interfaz.mostrarInfo("Opción inválida");
                        break;
                }
            } while (opcion != 'S');
        }
    }
}

