using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //ADO.NET
using Dal.Entity; //classes de entidade

namespace Dal.Persistence 
{
    public class MedicacaoDal : Conexao
    {
        public void Insert(Medicacao m)
        {
            try
            {
                OpenConnection(); //abrir conexão...
                Cmd = new SqlCommand("insert into Medicamentos(Nome, Descricao) values(@v1, @v2)", Con);
                Cmd.Parameters.AddWithValue("@v1", m.Nome);
                Cmd.Parameters.AddWithValue("@v2", m.Descricao);
                Cmd.ExecuteNonQuery(); //executar...
            }
            catch (Exception e)
            {
                //lançar exceção...
                throw new Exception("Erro ao inserir Medicamentos: " + e.Message);
            }
            finally
            {
                CloseConnection(); //fechar conexão..
            }
        }
    }
}
