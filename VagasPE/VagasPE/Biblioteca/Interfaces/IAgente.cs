using System;
using System.Collections.Generic;
using System.Text;
using VagasPE.Biblioteca.ClassesBasicas;

namespace VagasPE.Biblioteca.Interfaces {
    public interface IAgente {
        void CadastrarTrabalhador(Trabalhador trabalhador);
        void AtualizarTrabalhador(Trabalhador trabalhador);
        void DesativarTrabalhador(int trabalhadorId);
        List<Trabalhador> ListarTrabalhadores(string nome);
        List<Vaga> ListarVagas();
        void EfetuarInscricao(Trabalhador trabalhador, Vaga vaga);
    }
}