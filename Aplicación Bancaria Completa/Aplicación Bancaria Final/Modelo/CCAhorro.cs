using System;
namespace Banca
{
    class CCAhorro: CCuenta
    {
        //Métodos de Instancia
        //Constructores
        public CCAhorro(): this(0,"Sin Asignar")
        {}
        public CCAhorro(ulong clave, string nombre): base(clave, nombre)
        {
        }
    }
}

