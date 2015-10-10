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
    public partial class Medicos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }
        protected void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                Dal.Entity.Medico m = new Dal.Entity.Medico(); //classe de entidade...
                m.Nome = txtMedico.Text;
                m.Crm = txtCrm.Text;
                m.Descricao = txtDescricao.Text;



                MedicoDal mm = new MedicoDal(); //persistencia...
                mm.Insert(m); //gravando...

                lblMensagem.Text = "Médico " + m.Nome + ", cadastrado com sucesso.";

                //limpar os campos...
                txtMedico.Text = "";
                txtCrm.Text = "";
                txtDescricao.Text = "";


            }
            catch (Exception ex)
            {
                //imprimir mensagem de erro...
                lblMensagem.Text = ex.Message;

            }

        }
    }
}
