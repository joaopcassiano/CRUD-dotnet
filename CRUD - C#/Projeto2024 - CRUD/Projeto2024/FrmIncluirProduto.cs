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
    public partial class FrmIncluirProduto : MetroFramework.Forms.MetroForm
    {
        public FrmIncluirProduto()
        {
            InitializeComponent();
        }

        private Produto objetoProduto = new Produto();
        private Categoria objetoCategoria = new Categoria();
        
        private void FrmIncluirProduto_Load(object sender, EventArgs e)
        {
            cboCategoria.DisplayMember = "Nome_Categoria";
            cboCategoria.ValueMember = "Codigo_Categoria";
            cboCategoria.DataSource = objetoCategoria.PesquisaDados().Tables[0];
        }
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            objetoProduto.Nome_Produto = txtNome.Text;
            objetoProduto.Valor_Produto = double.Parse(txtValor.Text);
            objetoProduto.Codigo_Categoria = int.Parse(cboCategoria.SelectedValue.ToString());
            objetoProduto.Incluir();
            MessageBox.Show("Produto incluído com sucesso!!!");
            txtNome.Clear();
            txtValor.Clear();
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            objetoProduto.Codigo_Categoria = int.Parse(cboCategoria.SelectedValue.ToString());
        }
    }
}
