using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovoControleDeHorarios.br.com.projeto.conexao;
using NovoControleDeHorarios.br.com.projeto.model;
using System.Windows.Forms;
using System.Data;
using NovoControleDeHorarios.br.com.projeto.view;

namespace NovoControleDeHorarios.br.com.projeto.conexao {
    public class Mysql {
        #region Conexão ao banco e criação das tabelas
        //conexão com o banco de dados
        public static MySqlConnection Conexao;

        //função para execução das querys
        public static MySqlCommand Comando;

        //responsável por inserir dados em uma datatable
        public static MySqlDataAdapter Adaptador;

        //liga banco com propriedades datasource        
        public static DataTable datTabela;

        //Cria a tabela de usuários quando inicia o programa, caso não exista ainda
        public static void conectar() {
            //cria string de conexão ao BD
            string strCon = @"server=127.0.0.1;user id=root;Pwd=masterkey;persistsecurityinfo=True;";


            //estabelece parametros de conexão ao banco
            Conexao = new MySqlConnection(strCon);

            //Abre conexão com bd
            Conexao.Open();

            //cria o banco com instruções SQL
            Comando = new MySqlCommand("CREATE DATABASE IF NOT EXISTS bd_controle; use bd_controle", Conexao);

            //executa a query sql
            Comando.ExecuteNonQuery();

            //cria a tabela usuários
            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS bd_controle.tb_usuarios " +
                                        "(id integer (10) auto_increment primary key, " +
                                        "nome char(50) NOT NULL, " +
                                        "cpf char (11) NOT NULL, " +
                                        "permissao char (10) NOT NULL, " +
                                        "senha integer (04) NOT NULL, " +
                                        "UNIQUE (cpf), UNIQUE (senha))" +
                                        "ENGINE = InnoDB;", Conexao);

            Comando.ExecuteNonQuery();


            //Cria o usuário 1 Admin padrão
            Comando = new MySqlCommand("INSERT IGNORE INTO tb_usuarios(id, nome, cpf, permissao, senha) VALUES (null, 'Admin', '11111111111', 'Admin', 1234)", Conexao);
            Comando.ExecuteNonQuery();

            //cria a tabela HORÁRIOS
            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS bd_controle.tb_horarios (" +
                                        "Id_Reg INT NOT NULL AUTO_INCREMENT, " +
                                        "Cpf_Reg VARCHAR(11) NULL, " +
                                        "Nome_Reg VARCHAR(50) NULL, " +
                                        "Data_Reg VARCHAR(10) NOT NULL, " +
                                        "Entrada VARCHAR(05) NOT NULL, " +
                                        "Saida VARCHAR(05) NOT NULL, " +
                                        "Senha_Reg INT NOT NULL, " +
                                        "Fk_Id INT NOT NULL, " +
                                        "PRIMARY KEY(Id_Reg), " +
                                        "INDEX Fk_Usuarios_idx (Fk_Id ASC), " +
                                        "CONSTRAINT Fk_Usuario " +
                                        "FOREIGN KEY(Fk_Id) " +
                                        "REFERENCES bd_controle.tb_usuarios (id) " +
                                        "ON DELETE NO ACTION " +
                                        "ON UPDATE NO ACTION) " +
                                        "ENGINE = InnoDB; ", Conexao);

            Comando.ExecuteNonQuery();

            //autoriza alteração sem primary key
            Comando = new MySqlCommand("SET SQL_SAFE_UPDATES=0;", Conexao);

            Comando.ExecuteNonQuery();

            //Fecha a conexão com o banco
            Conexao.Close();

        }

#endregion
    }
}
