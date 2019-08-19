using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
   public abstract class CProfesional:IComparable
   //Lo óptimo es que sea abstact, aunque el enunciado no lo pide explícitamente.
   //Si se omite, no es crítico.
    {
        private uint matricula;
        private string nombre;
        private float honorarios;
        public CProfesional(uint mat, string nombApe)
        {
            this.matricula = mat;
            this.nombre = nombApe;
        }
        public uint darMatricula()
        {
            return this.matricula;
        }
        public void asignarHonorarios(float monto)
        {
            this.honorarios = monto;
        }
        public float darHonorarios()
        {
            return this.honorarios;
        }
        public virtual string darDatos()
        {
            string datos = "Mat.: " + Convert.ToString(this.matricula);
            datos += "\nDr. " + this.nombre;
            datos += "\nHonorarios: $" + this.honorarios.ToString();
            return datos;
        }
        public int CompareTo(object obj)
        {
            if (obj is CProfesional)
            {
                return (int)(this.darMatricula() - ((CProfesional)obj).darMatricula());
            }
            return int.MaxValue;
        }
    }
}
