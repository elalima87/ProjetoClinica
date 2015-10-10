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
    public partial class Medicacao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                Dal.Entity.Medicacao m = new Dal.Entity.Medicacao(); //classe de entidade...
                m.Nome = txtMedicamento.Text;
                m.Descricao = txtDescricao.Text;



                MedicacaoDal mm = new MedicacaoDal(); //persistencia...
                mm.Insert(m); //gravando...

                lblMensagem.Text = "Medicamento " + m.Nome + ", cadastrado com sucesso.";

                //limpar os campos...
                txtMedicamento.Text = "";
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