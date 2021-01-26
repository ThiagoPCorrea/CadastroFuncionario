using CadastroFuncionario.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CadastroFuncionario
{
    public partial class Cadastrar : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            HttpPostedFile file = upload.PostedFile;
            int FileSize = file.ContentLength;
            byte[] FileByteArray = new byte[FileSize];
            file.InputStream.Read(FileByteArray, 0, FileSize);

            CadastroViewModel.CadastrarFuncionario(new DadosCadastroViewModel()
            {
                Arquivo = FileByteArray,
                Bairro = bairro.Value,
                CEP = int.Parse(Regex.Replace(cep.Value, @"[^\d]", "")),
                Cidade = cidade.Value,
                Complemento = complemento.Value,
                CPF = cpf.Value,
                CTPS = ctps.Value,
                DataAdmissao = DateTime.Parse(dataAdmissao.Value),
                DataNascimento = DateTime.Parse(dataAdmissao.Value),
                Estado = estado.Value,
                Funcao = cargo.Value,
                Nome = nome.Value,
                Numero = int.Parse(Regex.Replace(numero.Value, @"[^\d]", "")),
                OrgaoEmissor = orgaoEmissor.Value,
                RG = int.Parse(Regex.Replace(rg.Value, @"[^\d]", "")),
                Rua = rua.Value,
                Sexo = sexo.Value,
                Telefone = long.Parse(Regex.Replace(tel.Value, @"[^\d]", ""))
            });
        }
    }
}