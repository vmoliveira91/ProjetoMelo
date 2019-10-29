using System;
using System.Collections.Generic;
using System.Text;

namespace VagasPE.Biblioteca.ClassesBasicas
{
    public class Empregador {
        private int id;
        private string cnpj;
        private string nomeFantasia;
        private string razaoSocial;
        private string endereco;
        private string email;
        private string telefone;
        private DateTime dataCadastro;
        private DateTime dataValidade;
        private bool ativo;

        public Empregador(int id = 0, string cnpj =  null, string nomeFantasia = null, string razaoSocial = null, string endereco = null, string email = null, string telefone = null, DateTime dataCadastro = default, DateTime dataValidade = default, bool ativo = false) {
            this.Id = id;
            this.Cnpj = cnpj;
            this.NomeFantasia = nomeFantasia;
            this.RazaoSocial = razaoSocial;
            this.Endereco = endereco;
            this.Email = email;
            this.Telefone = telefone;
            this.DataCadastro = dataCadastro;
            this.DataValidade = dataValidade;
            this.Ativo = ativo;
        }

        public int Id { get => id; set => id = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string NomeFantasia { get => nomeFantasia; set => nomeFantasia = value; }
        public string RazaoSocial { get => razaoSocial; set => razaoSocial = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public DateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }
        public DateTime DataValidade { get => dataValidade; set => dataValidade = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
    }
}