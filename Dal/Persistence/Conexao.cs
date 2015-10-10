using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //Acessar o SqlServer
using System.Configuration; //caminho da connectionstring...

namespace Dal.Persistence
{
    public class Conexao
    {
        //Atributos...
        protected SqlConnection Con;    //conexão com o SqlServer...
        protected SqlCommand Cmd;       //executar comandos SQL...
        protected SqlDataReader Dr;     //ler registros de consultas...

        //Métodos...
        protected void OpenConnection() //abrir conexão...
        {
            Con = new SqlConnection(ConfigurationManager.ConnectionStrings["aula"].ConnectionString);
            Con.Open();
        }

        protected void CloseConnection() //fechar conexão...
        {
            Con.Close();
        }
    }
}
