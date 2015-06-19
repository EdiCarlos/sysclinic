using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SysClinic.DAL.Repositorio
{
    public class Conexao
    {
        public static SqlConnection Conectar()
        {
            var conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["CNS1"].ConnectionString);
            if (conexao.State != ConnectionState.Open)          
            conexao.Open();
            return conexao;
        }

        public static void Crud(SqlCommand cm)
        {
            var con = Conectar();
            cm.Connection = con;
            cm.ExecuteNonQuery();
            con.Close();
        }

        public static SqlDataReader Buscar(SqlCommand cm)
        {
            var con = Conectar();
            cm.Connection = con;
            var dr = cm.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }


        public static object Selecionar(SqlCommand cm)
        {
            var con = Conectar();
            cm.Connection = con;
            var valor = cm.ExecuteScalar();
            return valor;
        }
    }
}
