using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projeto2024
{
    public partial class FrmPrincipal : MetroFramework.Forms.MetroForm
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void incluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIncluirCategoria fic = new FrmIncluirCategoria();
            fic.ShowDialog();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlterarCategoria fac = new FrmAlterarCategoria();
            fac.ShowDialog();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExcluirCategoria fec = new FrmExcluirCategoria();
            fec.ShowDialog();
        }

        private void incluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmIncluirProduto fip = new FrmIncluirProduto();
            fip.ShowDialog();
        }

        private void alterarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAlterarProduto fap = new FrmAlterarProduto();
            fap.ShowDialog();
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExcluirProduto fec  = new FrmExcluirProduto();
            fec.ShowDialog();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPesquisaCategoria fec = new FrmPesquisaCategoria();
            fec.ShowDialog();
        }

        private void categoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPesquisaCategoria pesquisa = new FrmPesquisaCategoria();
            pesquisa.ShowDialog();
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPesquisaProduto pesquisaProduto = new FrmPesquisaProduto();
            pesquisaProduto.ShowDialog();
        }

        private void impressãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmImprimir imprimir = new FrmImprimir();
            imprimir.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
