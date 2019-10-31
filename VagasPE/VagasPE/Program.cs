using System;
using VagasPE.Biblioteca.ConexaoBD;

namespace VagasPE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Conexao conexao = new Conexao();
            conexao.abrirConexao();
            conexao.select();
            conexao.fecharConexao();
        }
    }
}
