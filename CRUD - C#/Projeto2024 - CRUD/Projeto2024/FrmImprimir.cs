using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Projeto2024
{
    public partial class FrmImprimir : MetroFramework.Forms.MetroForm
    {
        public FrmImprimir()
        {
            InitializeComponent();
        }

        Categoria objetoCategoria = new Categoria();
        private int i;
        Produto objetoProduto = new Produto();
        private void button1_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.DocumentName = "Relatorio";
            pd.BeginPrint += Pd_BeginPrint;
            pd.PrintPage += Imprimir;

            //cria objeto de preview
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = pd;
            ppd.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.DocumentName = "Relatorio";
            pd.BeginPrint += Pd_BeginPrint;
            pd.PrintPage += ImprimirProduto;

            //cria objeto de preview
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = pd;
            ppd.ShowDialog();
        }

        private void Pd_BeginPrint(object sender, PrintEventArgs e)
        {
            i = 0;
        }

        private void Imprimir(object sender, PrintPageEventArgs ev)
        {
            //Configuração de Página
            float linhaPorPagina = 0;
            float posicaoVertical = 0;
            float contador = 0;
            float margemEsquerda = 20;
            float margemSuperior = 20;
            float alturaFonte = 0;

            string linha = "";

            Font fonte = new Font("Arial", 14);
            alturaFonte = fonte.GetHeight(ev.Graphics);
            linhaPorPagina = Convert.ToInt32(ev.MarginBounds.Height / alturaFonte);

            //Título

            linha = "Lista de Categorias";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

            contador += 4;

            linha = "Código";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

            linha = "Categoria";
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda + 500, posicaoVertical);


            linha = "--------------------------------------------------------------------------------------";
            contador += 1;
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

            contador++;
            DataSet ds = objetoCategoria.PesquisaCategoria();


            if (ds.Tables[0] != null)
            {
                while (i < ds.Tables[0].Rows.Count && contador < linhaPorPagina)
                {
                    DataRow item = ds.Tables[0].Rows[i];
                    linha = item["Codigo_Categoria"].ToString();
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);
                    linha = item["Nome_Categoria"].ToString();
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda + 500, posicaoVertical);

                    contador += 2;
                    i++;

                }
            }
            else MessageBox.Show("Sem Cadastro");

            if (contador > linhaPorPagina)
            {
                ev.HasMorePages = true;
            }
            else
            {
                ev.HasMorePages = false;
            }
        }

        private void ImprimirProduto(object sender, PrintPageEventArgs ev)
        {
            //Configuração de Página
            float linhaPorPagina = 0;
            float posicaoVertical = 0;
            float contador = 0;
            float margemEsquerda = 20;
            float margemSuperior = 20;
            float alturaFonte = 0;

            string linha = "";

            Font fonte = new Font("Arial", 14);
            alturaFonte = fonte.GetHeight(ev.Graphics);
            linhaPorPagina = Convert.ToInt32(ev.MarginBounds.Height / alturaFonte);

            //Título

            linha = "Lista de Produtos";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

            contador += 4;

            linha = "Código";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

            linha = "Produtos";
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda + 500, posicaoVertical);


            linha = "--------------------------------------------------------------------------------------";
            contador += 1;
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

            contador++;
            DataSet ds = objetoProduto.PesquisaProduto();


            if (ds.Tables[0] != null)
            {
                while (i < ds.Tables[0].Rows.Count && contador < linhaPorPagina)
                {
                    DataRow item = ds.Tables[0].Rows[i];
                    linha = item["Codigo_Produto"].ToString();
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);
                    linha = item["Nome_Produto"].ToString();
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda + 500, posicaoVertical);

                    contador += 2;
                    i++;

                }
            }
            else MessageBox.Show("Sem Cadastro");

            if (contador > linhaPorPagina)
            {
                ev.HasMorePages = true;
            }
            else
            {
                ev.HasMorePages = false;
            }
        }


    }
}
