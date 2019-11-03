using System;
using System.Collections.Generic;
using System.Text;
using VagasPE.Biblioteca.ClassesBasicas;

namespace VagasPE.Biblioteca.Interfaces {
    public interface ICaptador {
        void CadastrarEmpregador(Empregador empregador);
        void AtualizarEmpregador(Empregador empregador);
        void DesativarEmpregador(int empregadorId);
        List<Empregador> ListarEmpregadores(string nome);
        void CadastrarFuncao(Funcao funcao);
        void AtualizarFuncao(Funcao funcao);
        void DesativarFuncao(int funcaoId);
        List<Funcao> ListarFuncoes(string nome);
        void CadastrarVaga(Vaga vaga);
        void AtualizarVaga(Vaga vaga);
        void DesativarVaga(int vagaId);
        void CadastrarBeneficio(Beneficio beneficio);
        void AtualizarBeneficio(Beneficio beneficio);
        void DesativarBeneficio(int beneficioId);
        List<Beneficio> ListarBeneficios(string nome);
    }
}