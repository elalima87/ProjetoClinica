using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dal.Entity; //classes de entidade
using Dal.Persistence; //classes de acesso ao banco de dados

namespace Site.Pages
{
    public partial class Funcionario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                Dal.Entity.Funcionario f = new Dal.Entity.Funcionario(); //classe de entidade...
                f.Nome = txtNome.Text;
                f.Login = txtLogin.Text;
                f.Senha = txtSenha.Text;


                FuncionarioDal d = new FuncionarioDal(); //persistencia...
                d.Insert(f); //gravando...

                lblMensagem.Text = "Funcionário " + f.Nome + ", cadastrado com sucesso.";

                //limpar os campos...
                txtNome.Text = "";
                txtLogin.Text = "";
                txtSenha.Text = "";

            }
            catch (Exception ex)
            {
                //imprimir mensagem de erro...
                lblMensagem.Text = ex.Message;

            }
        }




        
    }
}
