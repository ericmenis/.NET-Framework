using System;
using System.Collections;
namespace Banca
{
    public class CCuentas
    {
        //Variables Miembro
        private ArrayList listado;

        //Constructor
        public CCuentas()
        {
            this.listado = new ArrayList();
        }

        //Metodos
        public CCuenta buscaCuenta(ulong clave)
        {
            foreach (CCuenta aux in this.listado)
                if (aux.getCbu() == clave)
                    return aux;
            return null;
        }

        public bool crearCuenta(ulong clave, string nombre)
        {
            if (this.buscaCuenta(clave) == null)
            {
                this.listado.Add(new CCAhorro(clave, nombre));
                return true;
            }
            return false;
        }
        public bool crearCuenta(ulong clave, string nombre, float descubierto)
        {
            if (this.buscaCuenta(clave) == null)
            {
                CCCorriente auxCCorriente = new CCCorriente(clave, nombre);
                auxCCorriente.setLimiteDesc(descubierto);
                this.listado.Add(auxCCorriente);
                return true;
            }
            return false;
        }

        public bool extraer(ulong clave, float monto)
        {
            CCuenta aux = this.buscaCuenta(clave);
            if (aux != null)
                return aux.extraer(monto);
            return false;
        }

        public bool depositar(ulong clave, float monto)
        {
            CCuenta aux = this.buscaCuenta(clave);
            if (aux != null)
            {
                aux.depositar(monto);
                return true;
            }
            return false;
        }

        public string darDatos(ulong clave)
        {
            CCuenta aux = this.buscaCuenta(clave);
            if (aux != null)
                return aux.darDatos();
            return "Cuenta inexistente";
        }

        public string darDatos()
        {
            String datos = "";
            this.listado.Sort();
            foreach (CCuenta aux in this.listado)
                datos += aux.darDatos() + "\n";
            return datos;
        }

        public bool eliminarCuenta(ulong clave)
        {
            CCuenta aux = this.buscaCuenta(clave);
            if (aux != null)
            {
                this.listado.Remove(aux);
                return true;
            }
            return false;
        }

        public void setGastos(float monto)
        {
            CCuenta.setGastos(monto);
        }
        public float getGastos()
        {
            return CCuenta.getGastos();
        }
    }
}

