using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace prjDoctorHelpDev
{
    class clsBD
    {
        static public SqlConnection AbreBanco()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Digite sua string aqui";
            conexao.Open();

            return conexao;
        }

        static public void ExecutarSQL(string SQL)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = AbreBanco();
            comando.CommandType = CommandType.Text;
            comando.CommandText = SQL;
            comando.ExecuteNonQuery();
        }

        static public SqlDataReader ExecutaConsultaDR(string SQL)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = AbreBanco();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = SQL;

            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            return dr;
        }

        static public DataTable ExecutaConsultaDT(string SQL)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = AbreBanco();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = SQL;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
