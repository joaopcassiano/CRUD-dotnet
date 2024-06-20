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
    public partial class FrmAlterarCategoria : MetroFramework.Forms.MetroForm
    {
        public FrmAlterarCategoria()
        {
            InitializeComponent();
        }

        private Categoria objetoCategoria = new Categoria();
        private void FrmAlterarCategoria_Load(object sender, EventArgs e)
        {
            cboCategoria.DisplayMember = "Nome_Categoria";
            cboCategoria.ValueMember = "Codigo_Categoria";
            cboCategoria.DataSource = objetoCategoria.PesquisaDados().Tables[0];
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            objetoCategoria.Codigo_Categoria = int.Parse(cboCategoria.SelectedValue.ToString());
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            objetoCategoria.Nome_Categoria = cboCategoria.Text;
            objetoCategoria.Alterar();
            MessageBox.Show("Categoria Alterada com Sucesso!!!");
            cboCategoria.DataSource = objetoCategoria.PesquisaDados().Tables[0];

        }
    }
}
