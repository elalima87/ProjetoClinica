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
    public partial class Paciente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                Dal.Entity.Paciente p = new Dal.Entity.Paciente(); //classe de entidade...
                p.NomePac    = txtNomePac.Text;
                p.Email      = txtEmail.Text;
                p.DataNasc   = DateTime.Parse(txtDataNasc.Text);
                p.NumeroTel  = Int32.Parse(txtNumeroTel.Text);
                p.TipoTel    = txtTipoTel.Text;
                

                PacienteDal pp = new PacienteDal(); //persistencia...
                pp.Insert(p); //gravando...


                Dal.Entity.Endereco end = new Dal.Entity.Endereco();
                end.Bairro = txtBairro.Text;
                end.Cidade = txtCidade.Text;
                end.Cep = txtCep.Text;
                end.Estado = txtEstado.Text;
                end.Logradouro = txtLogradouro.Text;
                end.Paciente = p;
                
                //PacienteDal ee = new PacienteDal();
                pp.Insert(end);                
                

                lblMensagem.Text = "Paciente " + p.NomePac + ", cadastrado com sucesso.";

                //limpar os campos...
                txtNomePac.Text     = "";
                txtEmail.Text       = "";
                txtDataNasc.Text    = "";
                txtNumeroTel.Text   = "";
                txtTipoTel.Text     = "";
            }
            catch (Exception ex)
            {
                //imprimir mensagem de erro...
                lblMensagem.Text = ex.Message;

            }
        }
    }
}