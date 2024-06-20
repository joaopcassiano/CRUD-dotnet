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
    public partial class FrmExcluirProduto : MetroFramework.Forms.MetroForm
    {
        public FrmExcluirProduto()
        {
            InitializeComponent();
        }
        private Produto objetoProduto = new Produto();
        private Categoria objetoCategoria = new Categoria();
        private void FrmExcluirProduto_Load(object sender, EventArgs e)
        {
            cboProduto.DisplayMember = "Nome_Produto";
            cboProduto.ValueMember = "Codigo_Produto";
            cboProduto.DataSource = objetoProduto.PesquisaDados().Tables[0];

            cboCategoria.DisplayMember = "Nome_Categoria";
            cboCategoria.ValueMember = "Codigo_Categoria";
            cboCategoria.DataSource = objetoCategoria.PesquisaDados().Tables[0];
        }

        private void cboProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            objetoProduto.Codigo_Produto = int.Parse(cboProduto.SelectedValue.ToString());
            DataTable dt = objetoProduto.PesquisaID();
            txtValor.Text = dt.Rows[0]["Valor_Produto"].ToString();
            cboCategoria.SelectedValue = int.Parse(dt.Rows[0]["Codigo_Categoria"].ToString());
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            objetoProduto.Codigo_Categoria = int.Parse(cboCategoria.SelectedValue.ToString());
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            objetoProduto.Nome_Produto = cboProduto.Text;
            objetoProduto.Valor_Produto = double.Parse(txtValor.Text);

            objetoProduto.Delete();
            MessageBox.Show("Produto excluído com sucesso!!!");

            cboProduto.DataSource = objetoProduto.PesquisaDados().Tables[0];
            cboCategoria.DataSource = objetoCategoria.PesquisaDados().Tables[0];
            txtValor.Clear();
        }
    }
}
