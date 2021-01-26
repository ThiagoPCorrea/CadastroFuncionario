using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroFuncionario.ViewModels
{
    public class DadosPesquisaViewModel
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Funcao { get; set; }
        public DateTime DataAdmissao { get; set; }
        public byte[] Arquivo { get; set; }
    }
}