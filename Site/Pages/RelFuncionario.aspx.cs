using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dal.Entity; //classes de entidade
using Dal.Persistence; //classes de acesso ao banco de dados
using Microsoft.Reporting.WebForms; //relatório...

namespace Site.Pages
{
    public partial class RelFuncionario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

         protected void btnPesquisa_Click(object sender, EventArgs e)
        {
         try
            {
                //resgatar as datas dos campos..
                string Nome = txtNomeF.Text;
                
                
                //pesquisar os produtos no banco de dados...
                Dal.Persistence.FuncionarioDal f = new Dal.Persistence.FuncionarioDal(); //classe de persistencia...
                List<Dal.Entity.Funcionario> lista = new List<Dal.Entity.Funcionario>();
                lista = f.FindAll(Nome);
                //exibir o relatorio dentro do ReportViewer...

                //Passo 1) Informar ao reportviewer o caminho do relatorio...                
                ReportViewer.LocalReport.ReportPath = HttpContext.Current.Server.
                                                      MapPath("/Reports/RelatorioFunc.rdlc");

                //Passo 2) Preencher o relatorio com os dados (dataset)
                ReportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSetFunc", lista));
                //exibir o relatório...
                ReportViewer.DataBind();
                
            }
            catch(Exception ex)
            {
                //imprimir mensagem de erro...
                lblMensagem.Text = ex.Message;
            }
        }
    }
}