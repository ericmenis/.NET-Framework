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
    public partial class frmPrincipal : Form
    {
        private frmSecundario fSec;
        public CVehículo vehículo;
        public void setVehículo(CVehículo auxVeh)
        {
            this.vehículo = auxVeh;
        }
        public CVehículo getVehículo()
        {
            return this.vehículo;
        }
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void establecerValorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (this.vehículo!=null)
            {
                if (this.fSec == null || this.fSec.IsDisposed) this.fSec = new frmSecundario();
                this.fSec.MdiParent = this;
                this.fSec.setFPrinc(this);
                this.fSec.Show();
            }
            else
            {
                MessageBox.Show("Para operar con los atributos, primero debe crear un vehículo", "Alerta");
            }
            
            
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.vehículo = new CVehículo();
            MessageBox.Show("Vehículo creado: " + this.vehículo.darDatos(),"Informe de Creación");
        }

        
    }
}
