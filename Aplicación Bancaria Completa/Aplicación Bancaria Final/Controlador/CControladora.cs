using System;
namespace Banca
{
    public class CControladora
    {
        public static void Main()
        {
            CCuentas listado = new CCuentas();
            char opcion;
            ulong auxClave;
            float auxMonto;
            do
            {
                opcion = Convert.ToChar(CInterfaz.darOpcion().ToUpper());
                //.ToUpper() Convierte la cadena a MAYÚSCULAS.
                switch (opcion)
                {
                    case 'G':
                        auxMonto = Convert.ToSingle(CInterfaz.pedirDato("Gastos Mensuales: $"));
                        listado.setGastos(auxMonto);
                        break;
                    case 'A':
                        char opcionCuenta;
                        bool cuentaCorriente=false, resultCreacion;
                        opcionCuenta = Convert.ToChar(CInterfaz.pedirDato("¿Es Cuenta Corriente [S|N]?: ").ToUpper());
                        if (opcionCuenta=='S') cuentaCorriente=true;
                        auxClave = Convert.ToUInt64(CInterfaz.pedirDato("CBU"));
                        string auxNombre = CInterfaz.pedirDato("Nombre");
                        if (cuentaCorriente == true)
                        {
                            //Solicito el dato adicional (límite de descubiert).
                            auxMonto = Convert.ToSingle(CInterfaz.pedirDato("Límite de DESCUBIERTO: $"));
                            //Invoco el creador de cuentas corrientes.
                            resultCreacion = listado.crearCuenta(auxClave, auxNombre, auxMonto);
                        }
                        else
                        {
                            //Invoco el creador de cajas de ahorro.
                            resultCreacion = listado.crearCuenta(auxClave, auxNombre);
                        }
                        if (!resultCreacion)
                        {
                            CInterfaz.mostrarInfo("CBU Preexistente");
                        }
                        break;
                    case 'D':
                        auxClave = Convert.ToUInt64(CInterfaz.pedirDato("CBU"));
                        auxMonto = Convert.ToSingle(CInterfaz.pedirDato("Monto"));
                        if (!listado.depositar(auxClave, auxMonto))
                        {
                            CInterfaz.mostrarInfo("Cuenta inexistente");
                        }
                        break;
                    case 'E':
                        auxClave = Convert.ToUInt64(CInterfaz.pedirDato("CBU"));
                        auxMonto = Convert.ToSingle(CInterfaz.pedirDato("Monto"));
                        if (!listado.extraer(auxClave, auxMonto))
                        {
                            CInterfaz.mostrarInfo("Cuenta inexistente, o fondos insuficientes.");
                        }
                        break;
                    case 'M':
                        auxClave = Convert.ToUInt64(CInterfaz.pedirDato("CBU"));
                        CInterfaz.mostrarInfo(listado.darDatos(auxClave));
                        break;
                    case 'L':
                        CInterfaz.mostrarInfo(listado.darDatos());
                        break;
                    case 'R':
                        auxClave = Convert.ToUInt64(CInterfaz.pedirDato("CBU"));
                        if (!listado.eliminarCuenta(auxClave))
                        {
                            CInterfaz.mostrarInfo("Cuenta Inexistente");
                        }
                        break;
                    case 'S':
                        break;
                    default:
                        CInterfaz.mostrarInfo("Opción inválida");
                        break;
                }
            } while (opcion != 'S');
        }
    }
}

