using System;
namespace Banca
{
    public abstract class CCuenta:IComparable
    {
        //Variables Miembro de Clase
        private static float gastosMensuales;
        //Variables Miembro de Instancia
        private ulong cbu;
        private string cliente;
        private float saldo;

        //Métodos de Instancia
        //Constructores
        public CCuenta()
            : this(0, "Sin Asignar")//invocación al constructor parametrizado.
        {/* 
          Opción equivalente a:
          this.cbu=0;
          this.cliente="Sin Asignar");
         */
        }
        public CCuenta(ulong clave, string nombre)
        {
            this.cbu = clave;
            this.cliente = nombre;
        }
        //Finalizadores
        ~CCuenta()
        {
            //Esto se ejecutará cuando se destruya la instancia.
        }
        public void dispose()
        {
            //Esto se ejecutará cuando se invoque este desinicializador explícito.
        }
        //Setters
        public void setCbu(ulong clave)
        {
            this.cbu = clave;
        }
        public void setCliente(string nomClie)
        {
            this.cliente = nomClie;
        }
        public void setSaldo(float monto)
        {
            this.saldo = monto;
        }
        //Getters
        public ulong getCbu()
        {
            return this.cbu;
        }
        public string getCliente()
        {
            return this.cliente;
        }
        public float getSaldo()
        {
            return this.saldo;
        }
        public static float getGastos()
        {
            return CCuenta.gastosMensuales;
        }
        public static void setGastos(float monto)
        {
            CCuenta.gastosMensuales = monto;
        }
        //Funcionales
        public void depositar(float monto)
        {
            if (monto > 0) this.saldo += monto;
        }

        public virtual bool extraer(float monto)
        {
            if ((monto <= this.saldo) && (monto>0))
            {
                this.saldo -= monto;
                return true;
            }
            return false;
        }
        //Implementación de IComparable.CompareTo()
        public int CompareTo(object obj)
        {
            if (obj is CCuenta)
            {
                return ((int)(this.cbu - ((CCuenta)obj).getCbu()));
            }
            throw new ArgumentException("Sólo definida la comparación entre instancias de CCuenta o clases derivadas");
        }
        public virtual string darDatos()
        {
            string datos = "*****************************************\n";
            datos += "Cuenta CBU: " + Convert.ToString(this.cbu) + ".\n";
            datos += "Cliente: " + this.cliente + ".\n";
            datos += "Saldo: $ " + Convert.ToString(this.saldo) + ".\n";
            datos += "Gastos Mensuales: $ " + Convert.ToString(CCuenta.getGastos() + ".\n");
            return datos;
        }
    }
}

