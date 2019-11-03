using System;
using System.Collections.Generic;
using System.Text;
using VagasPE.Biblioteca.ClassesBasicas;
using System.Data.SQLite;

namespace VagasPE.Biblioteca.ConexaoBD {
    public class BeneficioBD : Conexao {

        public BeneficioBD() : base() {}

        public void Insert(Beneficio beneficio) {
            string query = "INSERT INTO BENEFICIO(LABEL) VALUES(@Label);";
            try {
                this.abrirConexao();
                SQLiteCommand cmd = new SQLiteCommand(query, this.Conn);
                cmd.Parameters.AddWithValue("@Label", beneficio.Label);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.fecharConexao();
            } catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        public void Update(Beneficio beneficio) {
            string query;
            if(beneficio.Valor != 0)
                query = "UPDATE BENEFICIO SET LABEL = @Label, VALOR = @Valor WHERE ID = @Id;";
            else
                query = "UPDATE BENEFICIO SET LABEL = @Label WHERE ID = @Id;";
            try {
                this.abrirConexao();
                SQLiteCommand cmd = new SQLiteCommand(query, this.Conn);
                cmd.Parameters.AddWithValue("@Id", beneficio.Id);
                cmd.Parameters.AddWithValue("@Label", beneficio.Label);
                if(beneficio.Valor != 0)
                    cmd.Parameters.AddWithValue("@Valor", beneficio.Valor);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.fecharConexao();
            } catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        public void Delete(int beneficioId) {
            string query = "DELETE FROM BENEFICIO WHERE ID = @Id;";
            try {
                this.abrirConexao();
                SQLiteCommand cmd = new SQLiteCommand(query, this.Conn);
                cmd.Parameters.AddWithValue("@Id", beneficioId);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.fecharConexao();
            } catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        public List<Beneficio> Select(string nome = null) {
            List<Beneficio> beneficios = new List<Beneficio>();
            string query;
            if(nome != null)
                query = "SELECT * FROM BENEFICIO WHERE LABEL = @Label;";
            else
                query = "SELECT * FROM BENEFICIO;";
            try {
                this.abrirConexao();
                SQLiteCommand cmd = new SQLiteCommand(query, this.Conn);
                if(nome != null)
                    cmd.Parameters.AddWithValue("@Label", nome);
                SQLiteDataReader r = cmd.ExecuteReader();
                while(r.Read()) {
                    Beneficio beneficio = new Beneficio();
                    beneficio.Id = r.GetInt32(r.GetOrdinal("ID"));
                    beneficio.Label = (string) r["LABEL"];
                    beneficios.Add(beneficio);
                }
                cmd.Dispose();
                this.fecharConexao();
            } catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
            return beneficios;
        }
    }
}
