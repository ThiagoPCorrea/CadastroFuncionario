using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroFuncionario.Models
{
    public class EnderecoFuncionario : Base
    {
        public int CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public int? Numero { get; set; }
        public string Complemento { get; set; }

        public ICollection<DadosFuncionario> Funcionarios { get; set; }

    }
}