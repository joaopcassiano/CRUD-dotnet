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
    public partial class FrmPesquisaCategoria : MetroFramework.Forms.MetroForm
    {
        public FrmPesquisaCategoria()
        {
            InitializeComponent();
        }
        Categoria objetoCategoria = new Categoria();
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            objetoCategoria.Nome_Categoria = txtCategoria.Text;
            dataGridView1.DataSource = objetoCategoria.PesquisaCategoria().Tables[0];

        }
    }
}
