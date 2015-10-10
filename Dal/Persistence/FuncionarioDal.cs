using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //ADO.NET
using Dal.Entity; //classes de entidade

namespace Dal.Persistence
{
    public class FuncionarioDal : Conexao
    {
        public void Insert(Funcionario f)
        {
            try
            {
                OpenConnection(); //abrir conexão...
                Cmd = new SqlCommand("insert into Funcionario(Nome, Login, Senha, DataEntrada) values(@v1, @v2, @v3, GetDate())", Con);
                Cmd.Parameters.AddWithValue("@v1", f.Nome);
                Cmd.Parameters.AddWithValue("@v2", f.Login);
                Cmd.Parameters.AddWithValue("@v3", f.Senha);
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

        //Método para consultar os produtos por data...
        public List<Funcionario> FindAll(string Nome)
        {
            try
            {
                OpenConnection(); //abrir conexão...
                //Cmd = new SqlCommand("select * from Funcionario where Nome = '@V1'", Con);
                Cmd = new SqlCommand("select * from Funcionario where Nome like @V1", Con);
                Cmd.Parameters.AddWithValue("@v1", "%" + Nome + "%");
                Dr = Cmd.ExecuteReader(); //lê e retorna os dados para o SqlDataReader (Dr)

                List<Funcionario> lista = new List<Funcionario>(); //lista vazia...

                while (Dr.Read()) //lendo cada registro do select...
                {
                    Funcionario f = new Funcionario(); //classe de entidade...
                    f.IdFuncionario = Convert.ToInt32(Dr["IdFuncionario"]);
                    f.Nome = Convert.ToString(Dr["Nome"]);
                    f.Login = Convert.ToString(Dr["Login"]);
                    f.Senha = Convert.ToString(Dr["Senha"]);
                    f.DataEntrada = Convert.ToDateTime(Dr["DataEntrada"]);

                    lista.Add(f); //adicionar o produto dentro da lista... 
                }

                return lista; //retornar a lista...
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao consultar Funcionario: " + e.Message);
            }
            finally
            {
                CloseConnection(); //fechar conexão...
            }
        }

    }
}

