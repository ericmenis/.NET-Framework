using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concesionaria
{
    public class CVehículo
    {
        private ulong código;
        private string marca;
        private string modelo;
        private ushort año;
        private float precio;
        public CVehículo()
        {
            this.código = 0;
            this.marca = "Sin definir";
            this.modelo = "Sin definir";
            this.año = 1980;
            this.precio = 1000;
        }
        public void setCódigo(ulong cod)
        {
            this.código = cod;
        }
        public void setMarca(string marc)
        {
            this.marca = marc;
        }
        public void setModelo(string mod)
        {
            this.modelo = mod;
        }
        public void setAño(ushort a)
        {
            this.año = a;
        }
        public void setPrecio(float prec)
        {
            this.precio = prec;
        }
        public ulong getCódigo()
        {
            return this.código;
        }
        public string getMarca()
        {
            return this.marca;
        }
        public string getModelo()
        {
            return this.modelo;
        }
        public ushort getAño()
        {
            return this.año;
        }
        public float getPrecio()
        {
            return this.precio;
        }
        public string darDatos()
        {
            string datos = "Código: " + this.código.ToString();
            datos += " - Marca: " + this.marca;
            datos += " - Modelo: " + this.modelo;
            datos += " - Año: " + this.año.ToString();
            datos += " - Precio: $" + this.precio.ToString() + ".";
            return datos;
        }
    }
}
