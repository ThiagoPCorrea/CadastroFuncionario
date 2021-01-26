using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroFuncionario.ViewModels
{
    public class DadosCadastroViewModel
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public int RG { get; set; }
        public string OrgaoEmissor { get; set; }
        public DateTime DataAdmissao { get; set; }
        public long Telefone { get; set; }
        public string CTPS { get; set; }
        public byte[] Arquivo { get; set; }
        public int CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public int? Numero { get; set; }
        public string Complemento { get; set; }
        public string Funcao { get; set; }
    }
}