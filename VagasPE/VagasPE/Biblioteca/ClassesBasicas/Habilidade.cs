using System;
using System.Collections.Generic;
using System.Text;

namespace VagasPE.Biblioteca.ClassesBasicas {
    public class Habilidade {
        private int id;
        private string label;
        private string valor;
        private bool ativo;

        public Habilidade(int id = 0, string label = null, string valor = null, bool ativo = false) {
            this.Id = id;
            this.Label = label;
            this.Valor = valor;
        }

        public int Id { get => id; set => id = value; }
        public string Label { get => label; set => label = value; }
        public string Valor { get => valor; set => valor = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
    }
}