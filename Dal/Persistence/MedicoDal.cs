using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //ADO.NET
using Dal.Entity; //classes de entidade

namespace Dal.Persistence
{
    public class MedicoDal : Conexao
    {
        public void Insert(Medico md)
        {
            try
            {
                OpenConnection(); //abrir conexão...
                Cmd = new SqlCommand("insert into Medico(Nome, CRM, Descricao) values(@v1, @v2, @v3)", Con);
                Cmd.Parameters.AddWithValue("@v1", md.Nome);
                Cmd.Parameters.AddWithValue("@v2", md.Crm);
                Cmd.Parameters.AddWithValue("@v3", md.Descricao);
                Cmd.ExecuteNonQuery(); //executar...
            }
            catch (Exception e)
            {
                //lançar exceção...
                throw new Exception("Erro ao inserir Funcionário: " + e.Message);
            }
            finally
            {
                CloseConnection(); //fechar conexão..
            }
    }
}

    }

