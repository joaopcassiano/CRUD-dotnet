using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto2024
{
    public partial class FrmExcluirCategoria : MetroFramework.Forms.MetroForm
    {
        public FrmExcluirCategoria()
        {
            InitializeComponent();
        }

        private Categoria objetoCategoria = new Categoria();
        private void FrmExcluirCategoria_Load(object sender, EventArgs e)
        {
            cboCategoria.DisplayMember = "Nome_Categoria";
            cboCategoria.ValueMember = "Codigo_Categoria";
            cboCategoria.DataSource = objetoCategoria.PesquisaDados().Tables[0];
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            objetoCategoria.Codigo_Categoria = int.Parse(cboCategoria.SelectedValue.ToString());
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            objetoCategoria.Nome_Categoria = cboCategoria.Text;
            objetoCategoria.Delete();
            MessageBox.Show("Categoria Excluida com Sucesso!!!");
            cboCategoria.DataSource = objetoCategoria.PesquisaDados().Tables[0];
        }
    }
}
