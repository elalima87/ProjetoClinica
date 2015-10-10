using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //ADO.NET
using Dal.Entity; //classes de entidade

namespace Dal.Persistence
{
    public class PacienteDal : Conexao
    {
        public void Insert(Paciente p1)
        {
            try
            {
                OpenConnection(); //abrir conexão...
                Cmd = new SqlCommand("insert into Paciente(NOMEPAC, EMAIL, DATANASC,NUMEROTEL  , TIPOTEL) OUTPUT INSERTED.IdPaciente values(@v1, @v2, @v3, @v4 , @v5)", Con);
                Cmd.Parameters.AddWithValue("@v1", p1.NomePac);
                Cmd.Parameters.AddWithValue("@v2", p1.Email);
                Cmd.Parameters.AddWithValue("@v3", p1.DataNasc);
                Cmd.Parameters.AddWithValue("@v4", p1.NumeroTel);
                Cmd.Parameters.AddWithValue("@v5", p1.TipoTel);


                p1.IdPaciente = (int)Cmd.ExecuteScalar();
                //Cmd.ExecuteNonQuery(); //executar...

            }
            catch (Exception e)
            {
                //lançar exceção...
                throw new Exception("Erro ao inserir Paciente: " + e.Message);
            }
            finally
            {
                CloseConnection(); //fechar conexão..
            }
        }

        public void Insert(Endereco e1)
        {
            try
            {
                OpenConnection(); //abrir conexão...
                Cmd = new SqlCommand("insert into Endereco(LOGRADOURO, BAIRRO, CIDADE, ESTADO  , CEP , IDPACIENTE) OUTPUT INSERTED.IdEndereco values(@v1, @v2, @v3, @v4 , @v5 , @v6)", Con);
                Cmd.Parameters.AddWithValue("@v1", e1.Logradouro);
                Cmd.Parameters.AddWithValue("@v2", e1.Bairro);
                Cmd.Parameters.AddWithValue("@v3", e1.Cidade);
                Cmd.Parameters.AddWithValue("@v4", e1.Estado);
                Cmd.Parameters.AddWithValue("@v5", e1.Cep);
                Cmd.Parameters.AddWithValue("@v6", e1.Paciente.IdPaciente);

                e1.IdEndereco = (int)Cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                //lançar exceção...
                throw new Exception("Erro ao inserir Endereço: " + e.Message);
            }
            finally
            {
                CloseConnection(); //fechar conexão..
            }
        }
          
   }
}
