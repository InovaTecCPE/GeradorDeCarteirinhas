using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geradorCarteirinhaCPE
{
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            clnConfig cln = new clnConfig();
            cln.Ano_validade = dateValidade.Value.Year;
            cln.Cargo = cmbTipo.SelectedItem.ToString();
            cln.Tipo = cmbTipo.Items.IndexOf(cln.Cargo);
            this.Close();
        }

        private void FrmConfig_Load(object sender, EventArgs e)
        {
            clnConfig cln = new clnConfig();
            cmbTipo.SelectedItem = cln.Cargo;
        }
    }
}
