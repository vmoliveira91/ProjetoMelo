using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using VagasPE.Biblioteca.ClassesBasicas;

namespace VagasPE.Biblioteca.ConexaoBD {
    public class VagaBD : Conexao {

        public VagaBD() : base() { }

        public void Insert(Vaga vaga) {
            string query = "INSERT INTO VAGA(DESCRICAO, SALARIO, DATA_CADASTRO, DATA_VALIDADE, FUNCAO_ID, EMPREGADOR_ID, ATIVO) VALUES(@Descricao, @Salario, @DataCadastro, @DataValidade," +
                " @FuncaoId, @EmpregadorId, @Ativo);";
            try {
                this.abrirConexao();
                SQLiteCommand cmd = new SQLiteCommand(query, this.Conn);
                cmd.Parameters.AddWithValue("@Descricao", vaga.Descricao);
                cmd.Parameters.AddWithValue("@Salario", vaga.Salario);
                cmd.Parameters.AddWithValue("@DataCadastro", vaga.DataCadastro);
                cmd.Parameters.AddWithValue("@DataValidade", vaga.DataValidade);
                cmd.Parameters.AddWithValue("@FuncaoId", vaga.Funcao.Id);
                cmd.Parameters.AddWithValue("@EmpregadorId", vaga.Empregador.Id);
                cmd.Parameters.AddWithValue("@Ativo", vaga.Ativo);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.fecharConexao();
            } catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        public void Update(Vaga vaga) {
            string query = "UPDATE VAGA SET DESCRICAO = @Descricao, SALARIO = @Salario, DATA_CADASTRO = @DataCadastro, DATA_VALIDADE = @DataValidade, FUNCAO_ID = @FuncaoId, " +
                "EMPREGADOR_ID = @EmpregadorId, ATIVO = @Ativo WHERE ID = @Id;";
            try {
                this.abrirConexao();
                SQLiteCommand cmd = new SQLiteCommand(query, this.Conn);
                cmd.Parameters.AddWithValue("@Descricao", vaga.Descricao);
                cmd.Parameters.AddWithValue("@Salario", vaga.Salario);
                cmd.Parameters.AddWithValue("@DataCadastro", vaga.DataCadastro);
                cmd.Parameters.AddWithValue("@DataValidade", vaga.DataValidade);
                cmd.Parameters.AddWithValue("@FuncaoId", vaga.Funcao.Id);
                cmd.Parameters.AddWithValue("@EmpregadorId", vaga.Empregador.Id);
                cmd.Parameters.AddWithValue("@Ativo", vaga.Ativo);
                cmd.Parameters.AddWithValue("@Id", vaga.Id);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.fecharConexao();
            } catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        public void Delete(int vagaId) {
            string query = "DELETE FROM VAGA WHERE ID = @Id;";
            try {
                this.abrirConexao();
                SQLiteCommand cmd = new SQLiteCommand(query, this.Conn);
                cmd.Parameters.AddWithValue("@Id", vagaId);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.fecharConexao();
            } catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        public List<Vaga> Select(string descricao = null) {
            List<Vaga> vagas = new List<Vaga>();
            string query;
            if(descricao != null)
                query = "SELECT V.ID AS VID, V.DESCRICAO AS VDESCRICAO, V.SALARIO AS VSALARIO, V.DATA_CADASTRO AS VDATA_CADASTRO, V.DATA_VALIDADE AS VDATA_VALIDADE, V.FUNCAO_ID AS VFUNCAO_ID, V.EMPREGADOR_ID AS VEMPREGADOR_ID, V.ATIVO AS VATIVO, " +
                    "F.SIGLA AS FSIGLA, F.NOME AS FNOME, E.CNPJ AS ECNPJ, E.NOME_FANTASIA AS ENOME_FANTASIA, E.RAZAO_SOCIAL AS ERAZAO_SOCIAL, E.ENDERECO AS EENDERECO, E.EMAIL AS EEMAIL, E.TELEFONE AS ETELEFONE, " +
                    "E.DATA_CADASTRO AS EDATA_CADASTRO, E.DATA_VALIDADE AS EDATA_VALIDADE, E.ATIVO AS EATIVO " +
                    "FROM VAGA AS V " +
                    "JOIN FUNCAO AS F ON V.FUNCAO_ID = F.ID " +
                    "JOIN EMPREGADOR AS E ON V.EMPREGADOR_ID = E.ID " +
                    "WHERE V.DESCRICAO LIKE '%@Descricao%';";
            else
                query = "SELECT V.ID AS VID, V.DESCRICAO AS VDESCRICAO, V.SALARIO AS VSALARIO, V.DATA_CADASTRO AS VDATA_CADASTRO, V.DATA_VALIDADE AS VDATA_VALIDADE, V.FUNCAO_ID AS VFUNCAO_ID, V.EMPREGADOR_ID AS VEMPREGADOR_ID, V.ATIVO AS VATIVO, " +
                    "F.SIGLA AS FSIGLA, F.NOME AS FNOME, E.CNPJ AS ECNPJ, E.NOME_FANTASIA AS ENOME_FANTASIA, E.RAZAO_SOCIAL AS ERAZAO_SOCIAL, E.ENDERECO AS EENDERECO, E.EMAIL AS EEMAIL, E.TELEFONE AS ETELEFONE, " +
                    "E.DATA_CADASTRO AS EDATA_CADASTRO, E.DATA_VALIDADE AS EDATA_VALIDADE, E.ATIVO AS EATIVO " +
                    "FROM VAGA AS V " +
                    "JOIN FUNCAO AS F ON V.FUNCAO_ID = F.ID " +
                    "JOIN EMPREGADOR AS E ON V.EMPREGADOR_ID = E.ID;";
            try {
                this.abrirConexao();
                SQLiteCommand cmd = new SQLiteCommand(query, this.Conn);
                if(descricao != null)
                    cmd.Parameters.AddWithValue("@Descricao", descricao);
                SQLiteDataReader r = cmd.ExecuteReader();
                while(r.Read()) {

                    /*for(int i = 0; i < r.FieldCount; i++) {
                        Console.WriteLine(r.GetName(i));
                    }*/
                                        
                    Vaga vaga = new Vaga();
                    vaga.Id = r.GetInt32(r.GetOrdinal("VID"));
                    vaga.Descricao = (string) r["VDESCRICAO"];
                    vaga.Salario = r.GetDouble(r.GetOrdinal("VSALARIO"));
                    vaga.DataCadastro = r.GetDateTime(r.GetOrdinal("VDATA_CADASTRO"));
                    vaga.DataValidade = r.GetDateTime(r.GetOrdinal("VDATA_VALIDADE"));
                    int ativo = r.GetInt32(r.GetOrdinal("VATIVO"));
                    vaga.Ativo = ativo == 1 ? true : false;
                    vaga.Funcao = new Funcao();
                    vaga.Funcao.Id = r.GetInt32(r.GetOrdinal("VFUNCAO_ID"));
                    vaga.Funcao.Sigla = (string) r["FSIGLA"];
                    vaga.Funcao.Nome = (string) r["FNOME"];
                    vaga.Empregador = new Empregador();
                    vaga.Empregador.Id = r.GetInt32(r.GetOrdinal("VEMPREGADOR_ID"));
                    vaga.Empregador.Cnpj = (string) r["ECNPJ"];
                    vaga.Empregador.NomeFantasia = (string) r["ENOME_FANTASIA"];
                    vaga.Empregador.RazaoSocial = (string) r["ERAZAO_SOCIAL"];
                    vaga.Empregador.Endereco = (string) r["EENDERECO"];
                    vaga.Empregador.Email = (string)r["EEMAIL"];
                    vaga.Empregador.Telefone = (string) r["ETELEFONE"];
                    vaga.Empregador.DataCadastro = r.GetDateTime(r.GetOrdinal("EDATA_CADASTRO"));
                    vaga.Empregador.DataValidade = r.GetDateTime(r.GetOrdinal("EDATA_VALIDADE"));
                    ativo = r.GetInt32(r.GetOrdinal("EATIVO"));
                    vaga.Empregador.Ativo = ativo == 1 ? true : false;
                    vagas.Add(vaga);
                }
                cmd.Dispose();
                this.fecharConexao();
            } catch(Exception ex) {
                Console.WriteLine("ERROR: " + ex.Message);
            }
            return vagas;
        }
    }
 }