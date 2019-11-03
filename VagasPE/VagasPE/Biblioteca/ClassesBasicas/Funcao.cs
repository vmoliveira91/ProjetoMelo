using System;
using System.Collections.Generic;
using System.Text;

namespace VagasPE.Biblioteca.ClassesBasicas {
    public class Funcao {
        private int id;
        private string sigla;
        private string nome;
        private bool ativo;

        public Funcao(int id = 0, string sigla = null, string nome = null, bool ativo = false) {
            this.Id = id;
            this.Sigla = sigla;
            this.Nome = nome;
            this.Ativo = ativo;
        }

        public int Id { get => id; set => id = value; }
        public string Sigla { get => sigla; set => sigla = value; }
        public string Nome { get => nome; set => nome = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
    }
}
