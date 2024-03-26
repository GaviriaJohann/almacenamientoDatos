using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlmacenamientosDatos
{
    public partial class frmXml : Form
    {
        public frmXml()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmDatos frmDatos = new frmDatos();

            frmDatos.Show();

            this.Close();
        }
    }
}
