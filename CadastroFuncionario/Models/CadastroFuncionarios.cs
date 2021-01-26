using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CadastroFuncionario.Models
{
    public class CadastroFuncionarios : DbContext
    {
        public CadastroFuncionarios() : base("CadastroFuncionario"){}

        public DbSet<DadosFuncionario> DadosFuncionario { get; set; }
        public DbSet<EnderecoFuncionario> EnderecoFuncionario { get; set; }
        public DbSet<FuncaoFuncionario> FuncaoFuncionario { get; set; }

    }
}   