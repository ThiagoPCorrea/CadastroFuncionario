using CadastroFuncionario.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace CadastroFuncionario
{
    public partial class Pesquisar : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                var dados = PesquisaViewModel.PesquisarFuncionario(cpf.Value);

                var header = new List<string>() { "Nome", "CPF", "Data Nascimento", "Função", "Data Admissão", "Anexos" };
                var row = new HtmlTableRow();
                foreach (var valor in header)
                {
                    var cell = new HtmlTableCell();
                    cell.InnerText = valor;
                    row.Cells.Add(cell);
                }
                tabelaFuncionarios.Rows.Add(row);
                tabelaFuncionarios.Rows.Add(MakeRow(dados));

            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(Page, this.GetType(), "errorField", "errorField($('#cpf'));", true);
                ScriptManager.RegisterStartupScript(Page, this.GetType(), "showModal", "showModal('CPF não encontrado');", true);
            }
        }

        private HtmlTableRow MakeRow(DadosPesquisaViewModel dados)
        {
            var row = new HtmlTableRow();

            var cell = new HtmlTableCell();
            cell.InnerText = dados.Nome;
            row.Cells.Add(cell);

            cell = new HtmlTableCell();
            cell.InnerText = dados.CPF;
            row.Cells.Add(cell);

            cell = new HtmlTableCell();
            cell.InnerText = dados.DataNascimento.Date.ToString();
            row.Cells.Add(cell);

            cell = new HtmlTableCell();
            cell.InnerText = dados.Funcao;
            row.Cells.Add(cell);

            cell = new HtmlTableCell();
            cell.InnerText = dados.DataAdmissao.Date.ToString();
            row.Cells.Add(cell);

            cell = new HtmlTableCell();
            var downloadButton = new LinkButton();
            downloadButton.Text = "Documento";
            cell.Controls.Add(downloadButton);
            row.Cells.Add(cell);

            return row;
        }

    }
}