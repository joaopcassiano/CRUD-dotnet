using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Projeto2024
{
    internal class Conexao
    {
        SqlConnection conn = new SqlConnection();

        public void Conectar()
        {
            string aux = "SERVER=.\\SQLEXPRESS;Database=Banco2024;UID=sa;PWD=t2e4x6h1";
            conn.ConnectionString = aux;
            conn.Open();
        }
        public void Desconectar()
        {
            conn.Close();
        }
        public void Executar(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }
        public DataSet ListarDados(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public DataTable ListarID(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;

        }
    }
}
