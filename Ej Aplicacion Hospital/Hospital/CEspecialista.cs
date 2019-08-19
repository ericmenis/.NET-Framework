namespace Hospital
{
    public class CEspecialista:CProfesional
    {
        private static float bono;
        private bool admGuardias;
        
        public static void setBono(float porcentaje)
        {
            CEspecialista.bono = porcentaje;
        }
        public CEspecialista(uint mat, string nombApe, bool guardias): base(mat, nombApe)
        {
            this.admGuardias = guardias;
        }
        public float darRemuneracion()
        { 
            return this.darHonorarios()*(1+(CEspecialista.bono)/100);
        }
        public override string darDatos()
        {
            string retorno = base.darDatos();
            retorno+= "\nBono adicional: " + CEspecialista.bono.ToString() + " %";
            retorno += "\nAdmite Guardias: " + this.admGuardias.ToString();
            retorno += "\nRemuneración Total: $" + this.darRemuneracion().ToString();
            return retorno;
        }

    }
}
