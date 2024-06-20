using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projeto2024
{
    internal class Produto
    {
        private Conexao objetoConexao = new Conexao();
        private int codigo_Produto;
        private string nome_Produto;
        private double valor_Produto;
        private int codigo_Categoria;

        public int Codigo_Produto { get => codigo_Produto; set => codigo_Produto = value; }
        public string Nome_Produto { get => nome_Produto; set => nome_Produto = value; }
        public double Valor_Produto { get => valor_Produto; set => valor_Produto = value; }
        public int Codigo_Categoria { get => codigo_Categoria; set => codigo_Categoria = value; }

        public void Incluir()
        {
            string sql = "";
            sql += $"Insert into Produto (Nome_Produto, Valor_Produto, Codigo_Categoria) values ('{Nome_Produto}', {Valor_Produto.ToString().Replace(',','.')}, {Codigo_Categoria})";
            objetoConexao.Conectar();
            objetoConexao.Executar(sql);
            objetoConexao.Desconectar();
        }

        public void Alterar()
        {
            string sql = "";
            sql += $"Update Produto set Nome_Produto = '{Nome_Produto}',Valor_Produto = {Valor_Produto.ToString().Replace(',', '.')}," +
                $"Codigo_Categoria = {Codigo_Categoria} where Codigo_Produto = {Codigo_Produto}";
            objetoConexao.Conectar();
            objetoConexao.Executar(sql);
            objetoConexao.Desconectar();
        }
        public void Delete()
        {
            string sql = "";
            sql += $"Delete from Produto where Codigo_Produto = {Codigo_Produto}";
            objetoConexao.Conectar();
            objetoConexao.Executar(sql);
            objetoConexao.Desconectar();
        }
        public DataSet PesquisaDados()
        {
            string sql = $"Select * from Produto";
            objetoConexao.Conectar();
            DataSet ds = objetoConexao.ListarDados(sql);
            objetoConexao.Desconectar();
            return ds;
        }

        public DataTable PesquisaID()
        {
            string sql = $"Select * from Produto where Codigo_Produto = {Codigo_Produto}";
            objetoConexao.Conectar();
            DataTable dt = objetoConexao.ListarID(sql);
            objetoConexao.Desconectar();
            return dt;
        }
        public DataSet PesquisaProduto()
        {
            string sql = "Select * from Produto where Nome_Produto like '" + Nome_Produto + "%'";
            objetoConexao.Conectar();
            DataSet ds = objetoConexao.ListarDados(sql);
            objetoConexao.Desconectar();
            return ds;
        }
    }
}
