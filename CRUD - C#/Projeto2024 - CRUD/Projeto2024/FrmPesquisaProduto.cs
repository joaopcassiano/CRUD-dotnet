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
    public partial class FrmPesquisaProduto : MetroFramework.Forms.MetroForm
    {
        public FrmPesquisaProduto()
        {
            InitializeComponent();
        }

        Produto objetoProduto = new Produto();
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            objetoProduto.Nome_Produto = txtProduto.Text;
            dataGridView1.DataSource = objetoProduto.PesquisaProduto().Tables[0];
        }
    }
}
