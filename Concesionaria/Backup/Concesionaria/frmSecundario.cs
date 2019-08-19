using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Concesionaria
{
    public partial class frmSecundario : Form
    {
        private frmPrincipal fPrinc;
        public void setFPrinc(frmPrincipal fP)
        {
            this.fPrinc = fP;
        }
        public frmPrincipal getFPrinc()
        {
            return this.fPrinc;
        }
        public frmSecundario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ulong cod;
            ushort a;
            float prec;
            bool validacion=ulong.TryParse(txtCódigo.Text, out cod);
            validacion&=ushort.TryParse(txtAño.Text, out a);
            validacion&=float.TryParse(txtPrecio.Text,out prec);
            CVehículo auxVeh = this.fPrinc.getVehículo();
            if (validacion == true)
            {
                auxVeh.setCódigo(cod);
                auxVeh.setMarca(txtMarca.Text);
                auxVeh.setModelo(txtModelo.Text);
                auxVeh.setAño(a);
                auxVeh.setPrecio(prec);
                this.Close();
            }
            else MessageBox.Show("Verifique los valores introducidos", "Operación abortada");
        }

        private void frmSecundario_Load(object sender, EventArgs e)
        {
            CVehículo auxVeh = this.fPrinc.getVehículo();
            this.txtCódigo.Text = auxVeh.getCódigo().ToString();
            this.txtMarca.Text = auxVeh.getMarca();
            this.txtModelo.Text = auxVeh.getModelo();
            this.txtAño.Text = auxVeh.getAño().ToString();
            this.txtPrecio.Text = auxVeh.getPrecio().ToString();
        }
    }
}
