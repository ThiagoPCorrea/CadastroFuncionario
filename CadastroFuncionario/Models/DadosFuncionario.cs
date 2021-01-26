using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroFuncionario.Models
{
    public class DadosFuncionario : Base
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

        public FuncaoFuncionario Cargo { get; set; }
        public EnderecoFuncionario Endereco { get; set; }
    }
}