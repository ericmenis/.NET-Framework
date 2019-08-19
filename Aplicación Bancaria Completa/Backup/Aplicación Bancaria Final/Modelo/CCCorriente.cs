using System;
namespace Banca
{
    class CCCorriente:CCuenta
    {
        private float limDescub;
        private static float interesDescub;
        public CCCorriente(ulong clave, string nomClie): base(clave, nomClie)
        { }
        public CCCorriente():this(0,"Sin Asignar")
        {}
        public void setLimiteDesc(float monto)
        {
            this.limDescub = monto;
        }
        public float getLimiteDesc()
        {
            return this.limDescub;
        }
        public static void setInteresDescubierto(float porcentaje)
        {
            CCCorriente.interesDescub = porcentaje;
        }
        public static float getInteresDescubierto()
        {
            return CCCorriente.interesDescub;
        }
        public override bool extraer(float monto)
        {
            if ((monto <= this.getSaldo()+this.limDescub) && (monto > 0))
            {
                this.setSaldo(this.getSaldo()-monto);
                return true;
            }
            return false;
        }
        public override string darDatos()
        {
            string datos = base.darDatos();
            datos += "\nLímite al Descubierto: $ " + Convert.ToString(this.limDescub) + ".";
            return datos;
        }
    }
}
