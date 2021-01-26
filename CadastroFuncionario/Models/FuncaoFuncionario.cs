using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroFuncionario.Models
{
    public class FuncaoFuncionario : Base
    {
        public string Funcao { get; set; }

        public ICollection<DadosFuncionario> Funcionarios { get; set; }
    }
}