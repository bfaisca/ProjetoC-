using ProjetoPizzaria.Formulario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPizzaria
{
    public partial class Frm_MdiInicio : Form
    {
        public Frm_MdiInicio()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CadCliente objFrm = new Frm_CadCliente();
            objFrm.MdiParent = this;
            objFrm.Show();

        }
    }
}
