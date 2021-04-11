using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace FormInova
{
    public partial class frmPrincipal : DevExpress.XtraEditors.XtraForm
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void tileControl1_Click(object sender, EventArgs e)
        {

        }

        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            frmCadastrarFuncionario newXtra = new frmCadastrarFuncionario();
            newXtra.Show();
        }
    }
}