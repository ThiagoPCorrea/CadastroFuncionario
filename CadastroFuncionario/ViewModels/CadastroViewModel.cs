using CadastroFuncionario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroFuncionario.ViewModels
{
    public static class CadastroViewModel
    {
        public static void CadastrarFuncionario(DadosCadastroViewModel dados)
        {
                var funcionario = retornaFuncionario(dados);
                var endereco = retornaEndereco(dados);
                var cargo = retornaFuncao(dados);
                funcionario.Endereco = endereco;
                funcionario.Cargo = cargo;

            using (var db = new CadastroFuncionarios())
            {
                db.DadosFuncionario.Add(funcionario);
                db.EnderecoFuncionario.Add(endereco);
                db.FuncaoFuncionario.Add(cargo);

                db.SaveChanges();
            }
        }

        private static DadosFuncionario retornaFuncionario(DadosCadastroViewModel dados)
        {
            return new DadosFuncionario()
            {
                Arquivo = dados.Arquivo,
                CPF = dados.CPF,
                CTPS = dados.CTPS,
                DataAdmissao = dados.DataAdmissao,
                DataNascimento = dados.DataNascimento,
                Nome = dados.Nome,
                OrgaoEmissor = dados.OrgaoEmissor,
                RG = dados.RG,
                Sexo = dados.Sexo,
                Telefone = dados.Telefone
            };
        }

        private static EnderecoFuncionario retornaEndereco(DadosCadastroViewModel dados)
        {
            return new EnderecoFuncionario()
            {
                Bairro = dados.Bairro,
                CEP = dados.CEP,
                Cidade = dados.Cidade,
                Complemento = dados.Complemento,
                Estado = dados.Estado,
                Numero = dados.Numero,
                Rua = dados.Rua
            };
        }

        private static FuncaoFuncionario retornaFuncao(DadosCadastroViewModel dados)
        {
            return new FuncaoFuncionario()
            {
                Funcao = dados.Funcao
            };
        }
    }
}