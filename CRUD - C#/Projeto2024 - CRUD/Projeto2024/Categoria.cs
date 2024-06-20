using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projeto2024
{
    internal class Categoria
    {
        private Conexao objetoConexao = new Conexao();
        private int codigo_Categoria;
        private string nome_Categoria;

        public int Codigo_Categoria { get => codigo_Categoria; set => codigo_Categoria = value; }
        public string Nome_Categoria { get => nome_Categoria; set => nome_Categoria = value; }

        public void Incluir()
        {
            string sql = "";
            sql += "Insert into Categoria(Nome_Categoria) values ('" + Nome_Categoria + "' )";
            objetoConexao.Conectar();
            objetoConexao.Executar(sql);
            objetoConexao.Desconectar();
        }

        public void Alterar()
        {
            string sql = "";
            sql += $"Update Categoria set Nome_Categoria = '{Nome_Categoria}' where Codigo_Categoria = " + Codigo_Categoria.ToString();
            objetoConexao.Conectar();
            objetoConexao.Executar(sql);
            objetoConexao.Desconectar();
        }
        public void Delete()
        {
            string sql = "";
            sql += "Delete from Categoria where Codigo_Categoria = " + Codigo_Categoria.ToString();
            objetoConexao.Conectar();
            objetoConexao.Executar(sql);
            objetoConexao.Desconectar();
        }

        public DataSet PesquisaDados()
        {
            string sql = "Select * from Categoria";
            objetoConexao.Conectar();
            DataSet ds = objetoConexao.ListarDados(sql);
            objetoConexao.Desconectar();
            return ds;
        }
        public DataSet PesquisaCategoria()
        {
            string sql = "Select * from Categoria where Nome_Categoria like '" + Nome_Categoria + "%'";
            objetoConexao.Conectar();
            DataSet ds = objetoConexao.ListarDados(sql);
            objetoConexao.Desconectar();
            return ds;
        }
        
    }
}
