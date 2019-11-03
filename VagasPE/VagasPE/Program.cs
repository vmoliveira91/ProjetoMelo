using System;
using VagasPE.Biblioteca.ConexaoBD;
using VagasPE.Biblioteca.ClassesBasicas;
using System.Data.SQLite;
using System.Collections.Generic;

namespace VagasPE
{
    class Program {
        static void Main(string[] args) {
            VagaBD conexao = new VagaBD();
            //conexao.Insert(new Vaga(0, "Analista de Sistemas", 1740, default, default, new Funcao(2), new Empregador(1), null, null, true));
            List<Vaga> vagas = conexao.Select("Prog");
            //Console.WriteLine(vagas.Count);
            for(int i = 0; i < vagas.Count; i++) {
                Console.WriteLine(vagas[i].Id);
                Console.WriteLine(vagas[i].Descricao);
                Console.WriteLine(vagas[i].Salario);
                Console.WriteLine(vagas[i].DataCadastro);
                Console.WriteLine(vagas[i].DataValidade);
                Console.WriteLine(vagas[i].Funcao.Id);
                Console.WriteLine(vagas[i].Funcao.Sigla);
                Console.WriteLine(vagas[i].Funcao.Nome);
                Console.WriteLine(vagas[i].Empregador.Id);
                Console.WriteLine(vagas[i].Empregador.Cnpj);
                Console.WriteLine(vagas[i].Empregador.NomeFantasia);
                Console.WriteLine(vagas[i].Empregador.RazaoSocial);
                Console.WriteLine(vagas[i].Empregador.Endereco);
                Console.WriteLine(vagas[i].Empregador.Email);
                Console.WriteLine(vagas[i].Empregador.Telefone);
                Console.WriteLine(vagas[i].Empregador.DataCadastro);
                Console.WriteLine(vagas[i].Empregador.DataValidade);
                Console.WriteLine(vagas[i].Empregador.Ativo);
            }

        }
    }
}
