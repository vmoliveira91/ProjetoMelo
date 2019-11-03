using System;
using System.Collections.Generic;
using System.Text;

namespace VagasPE.Biblioteca.ClassesBasicas {
    public class Beneficio {
        private int id;
        private string label;
        private double valor;
        private bool ativo;

        public Beneficio(int id = 0, string label =  null, double valor = 0, bool ativo = false) {
            this.Id = id;
            this.Label = label;
            this.Valor = valor;
            this.Ativo = ativo;
        }

        public int Id { get => id; set => id = value; }
        public string Label { get => label; set => label = value; }
        public double Valor { get => valor; set => valor = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
    }
}
