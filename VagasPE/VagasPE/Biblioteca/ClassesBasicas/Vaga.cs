using System;
using System.Collections.Generic;
using System.Text;

namespace VagasPE.Biblioteca.ClassesBasicas {
    public class Vaga {
        private int id;
        private string descricao;
        private double salario;
        private DateTime dataCadastro;
        private DateTime dataValidade;
        private Funcao funcao;
        private Empregador empregador;
        private List<Experiencia> experiencias;
        private List<Habilidade> habilidades;
        private bool ativo;

        public Vaga(int id = 0, string descricao = null, double salario = 0, DateTime dataCadastro = default, DateTime dataValidade= default, Funcao funcao = null, Empregador empregador = null, List<Experiencia> experiencias = null, List<Habilidade> habilidades = null, bool ativo = false) {
            this.Id = id;
            this.Descricao = descricao;
            this.Salario = salario;
            this.DataCadastro = dataCadastro;
            this.DataValidade = dataValidade;
            this.Funcao = funcao;
            this.Empregador = empregador;
            this.Experiencias = experiencias;
            this.Habilidades = habilidades;
            this.Ativo = ativo;
        }

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double Salario { get => salario; set => salario = value; }
        public DateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }
        public DateTime DataValidade { get => dataValidade; set => dataValidade = value; }
        public Funcao Funcao { get => funcao; set => funcao = value; }
        public Empregador Empregador { get => empregador; set => empregador = value; }
        public List<Experiencia> Experiencias { get => experiencias; set => experiencias = value; }
        public List<Habilidade> Habilidades { get => habilidades; set => habilidades = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
    }
}