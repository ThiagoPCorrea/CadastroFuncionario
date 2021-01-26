using CadastroFuncionario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CadastroFuncionario.ViewModels
{
    public static class PesquisaViewModel
    {
        public static DadosPesquisaViewModel PesquisarFuncionario(string cpf)
        {
            using (var db = new CadastroFuncionarios())
            {
                var funcionario = db.DadosFuncionario.
                    Include(funcao => funcao.Cargo).
                    FirstOrDefault(funcionarios => funcionarios.CPF == cpf);

                return new DadosPesquisaViewModel()
                {
                    Nome = funcionario.Nome,
                    CPF = funcionario.CPF,
                    Arquivo = funcionario.Arquivo,
                    DataAdmissao = funcionario.DataAdmissao,
                    DataNascimento = funcionario.DataNascimento,
                    Funcao = funcionario.Cargo.Funcao
                };
            }
            
        }
    }
}