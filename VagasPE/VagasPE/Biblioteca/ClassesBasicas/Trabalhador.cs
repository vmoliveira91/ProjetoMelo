using System;
using System.Collections.Generic;
using System.Text;

namespace VagasPE.Biblioteca.ClassesBasicas {
    public class Trabalhador {
        private int id;
        private string cpf;
        private string rg;
        private string nome;
        private string sexo;
        private string endereco;
        private string telefone;
        private string email;
        private string nacionalidade;
        private DateTime dataNascimento;
        private DateTime dataCadastro;
        private DateTime dataValidade;
        private List<Experiencia> experiencias;
        private List<Habilidade> habilidades;
        private bool ativo;
        private string status;

        public Trabalhador(int id = 0, string cpf = null, string rg = null, string nome = null, string sexo = null, string endereco = null, string telefone = null, string email = null, string nacionalidade = null, DateTime dataNascimento = default, DateTime dataCadastro = default, DateTime dataValidade = default, List<Experiencia> experiencias = null, List<Habilidade> habilidades = null, bool ativo = false, string status = null) {
            this.Id = id;
            this.Cpf = cpf;
            this.Rg = rg;
            this.Nome = nome;
            this.Sexo = sexo;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Email = email;
            this.Nacionalidade = nacionalidade;
            this.DataNascimento = dataNascimento;
            this.DataCadastro = dataCadastro;
            this.DataValidade = dataValidade;
            this.Experiencias = experiencias;
            this.Habilidades = habilidades;
            this.Ativo = ativo;
            this.Status = status;
        }

        public int Id { get => id; set => id = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public string Nacionalidade { get => nacionalidade; set => nacionalidade = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public DateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }
        public DateTime DataValidade { get => dataValidade; set => dataValidade = value; }
        public List<Experiencia> Experiencias { get => experiencias; set => experiencias = value; }
        public List<Habilidade> Habilidades { get => habilidades; set => habilidades = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
        public string Status { get => status; set => status = value; }
    }
}