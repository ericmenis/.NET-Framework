using System;
using System.Collections;
namespace Hospital
{
    public class CCartilla
    {
        private ArrayList listado;

        public CCartilla()
        {
            this.listado = new ArrayList(0);
        }
        public CEspecialista buscar(uint mat)
        {
            foreach (CEspecialista auxEspec in this.listado)
            {
                if (auxEspec.darMatricula() == mat) return auxEspec;
            }
            return null;
        }
        public bool registrar(uint mat, string nombApe, float monto, bool guardias)
        {
            CEspecialista auxEspec = this.buscar(mat);
            if (auxEspec == null)
            {
                auxEspec = new CEspecialista(mat, nombApe, guardias);
                auxEspec.asignarHonorarios(monto);
                this.listado.Add(auxEspec);
                return true;
            }
            return false;
        }
        public bool remover(uint mat)
        {
            CEspecialista auxApart = this.buscar(mat);
            if (auxApart != null) 
            {
                this.listado.Remove(auxApart);
                return true;
            }
            return false;
        }
        public string darDatos(uint mat)
        {
            CEspecialista auxApart = this.buscar(mat);
            if (auxApart != null) return auxApart.darDatos();
            return "Especialista NO registrado";
        }
    }
}
