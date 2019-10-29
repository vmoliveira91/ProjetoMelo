using System;
using System.Collections.Generic;
using System.Text;

namespace VagasPE.Biblioteca.ClassesBasicas {
    public class Funcao {
        private int id;
        private string sigla;
        private string nome;

        public Funcao(int id = 0, string sigla = null, string nome = null) {
            this.Id = id;
            this.Sigla = sigla;
            this.Nome = nome;
        }

        public int Id { get => id; set => id = value; }
        public string Sigla { get => sigla; set => sigla = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}
