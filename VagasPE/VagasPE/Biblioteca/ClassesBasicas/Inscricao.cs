using System;
using System.Collections.Generic;
using System.Text;

namespace VagasPE.Biblioteca.ClassesBasicas {
    class Inscricao {
        private int id;
        private DateTime dataInscricao;
        private Vaga vaga;
        private Trabalhador trabalhador;
        private string situacao;
        private bool ativo;

        public Inscricao(int id = 0, DateTime dataInscricao = default, Vaga vaga = null, Trabalhador trabalhador = null, string situacao = null, bool ativo = false) {
            this.Id = id;
            this.DataInscricao = dataInscricao;
            this.Vaga = vaga;
            this.Trabalhador = trabalhador;
            this.Situacao = situacao;
            this.Ativo = ativo;
        }

        public int Id { get => id; set => id = value; }
        public DateTime DataInscricao { get => dataInscricao; set => dataInscricao = value; }
        public Vaga Vaga { get => vaga; set => vaga = value; }
        public Trabalhador Trabalhador { get => trabalhador; set => trabalhador = value; }
        public string Situacao { get => situacao; set => situacao = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
    }
}
