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
    public partial class FrmIncluirCategoria : MetroFramework.Forms.MetroForm
    {
        public FrmIncluirCategoria()
        {
            InitializeComponent();
        }

        Categoria objetoCategoria;
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            objetoCategoria = new Categoria();
            objetoCategoria.Nome_Categoria = txtCategoria.Text;
            objetoCategoria.Incluir();
            MessageBox.Show("Categoria incluida com sucesso!!!");
        }
    }
}
