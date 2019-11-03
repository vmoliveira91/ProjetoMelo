using System;
using System.Collections.Generic;
using System.Text;
using VagasPE.Biblioteca.ClassesBasicas;

namespace VagasPE.Biblioteca.Interfaces {
    public interface IGerente {
        void CadastrarHabilidade(Habilidade habilidade);
        void AtualizarHabilidade(Habilidade habilidade);
        void RemoverHabilidade(int habilidadeId);
        List<Habilidade> ListarHabilidades(string nome);
        void CadastrarExperiencia(Experiencia experiencia);
        void AtualizarExperiencia(Experiencia experiencia);
        void RemoverExperiencia(int experienciaId);
        List<Experiencia> ListarExperiencias(string nome);
        void CadastrarNivel(string nivel);
        void AtualizarNivel(string nivel);
        void RemoverNivel(int nivelId);
        List<string> ListarNiveis(string nome);
        void CadastrarTempo(string tempo);
        void AtualizarTempo(string tempo);
        void RemoverTempo(int tempoId);
        List<string> ListarTempos(string nome);
        void CadastrarSituacao(string nome);
        void AtualizarSituacao(string situacao);
        void RemoverSituacao(int situacaoId);
        List<string> ListarSituacoes(string nome);
    }
}