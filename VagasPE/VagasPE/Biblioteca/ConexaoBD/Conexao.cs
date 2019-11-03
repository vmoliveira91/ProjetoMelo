using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;

namespace VagasPE.Biblioteca.ConexaoBD {
    public class Conexao {
        private SQLiteConnection conn;

        public Conexao() {
            // Vitor
            this.conn = new SQLiteConnection(@"Data Source=C:\Users\VITOR.OLIVEIRA\Documents\ProjetoMelo\BancoDeDados.db");
            // Hivson
            //this.conn = new SQLiteConnection(@"Data Source=C:\Users\HIVSON.MATHEUS\Desktop\ProjetoMelo\BancoDeDados.db;Version=3;New=False;Compress=True;");
            // Nicholas
            //this.conn = new SQLiteConnection(@"Data Source=C:\Users\nickm\Desktop\ProjetoMelo\BancoDeDados.bd;Version=3;New=False;Compress=True;");
            // Santhiago
            //this.conn = new SQLiteConnection(@"Data Source=C:\git\ProjetoMelo\BancoDeDados.db;Version=3;New=False;Compress=True;");
        }

        public SQLiteConnection Conn { get => conn; set => conn = value; }

        public void abrirConexao() {
            this.conn.Open();
        }

        public void fecharConexao() {
            this.conn.Close();
        }
    }
}