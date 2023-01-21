using System;
using System.Data;
using Crud_Login.models;
using MySql.Data.MySqlClient;

namespace Crud_Login {
    public class UsuarioRepository : IUsuarioRepository {

        private const string bancoDados = "server=localhost;uid=usuario;pwd=;database=db_login;";
        private MySqlConnection conexaoBd;
        private MySqlCommand comando;
        private const string criarTabelaUsuarioQuery = "CREATE TABLE IF NOT EXISTS usuario(" +
                                                "id INT AUTO_INCREMENT," +
                                                "email VARCHAR(180) NOT NULL," +
                                                "senha VARCHAR(100) NOT NULL," +
                                                "PRIMARY KEY(id));";

        public UsuarioRepository() {
            try {
                conexaoBd = new MySqlConnection(bancoDados);
                conexaoBd.Open();
                comando = new MySqlCommand(criarTabelaUsuarioQuery, conexaoBd);
                comando.ExecuteReader();

                Console.WriteLine("Conexão realizada com sucesso...");
            } catch (Exception err) {
                Console.WriteLine("Erro de conexão: " + err.Message);
            } finally {
                conexaoBd.Close();
            }
        }

        public void salvar(Usuario usuario) {
            string query = "INSERT INTO usuario(email, senha)" +
                           "VALUES('" + usuario.email + "', '" + usuario.senha + "');";
            executarComando(query);
        }

        public void atualizar(string email, Usuario usuario) {
            int id = getPorEmail(email).id;

            string query = "UPDATE usuario SET " +
                "email = '" + usuario.email + "', " +
                "senha = '" + usuario.senha + "'" +
                "WHERE id = " + id + ";";
            executarComando(query);
        }

        public void deletar(Usuario usuario) {
            string query = "DELETE FROM usuario " +
                "WHERE id = " + usuario.id + " OR email = '" + usuario.email + "';";
            executarComando(query);
        }

        public bool existePorEmail(string email) {
            string query = "SELECT * FROM usuario WHERE email = '" + email + "';";

            try {
                conexaoBd.Open();
                comando = new MySqlCommand(query, conexaoBd);
                MySqlDataReader dados = comando.ExecuteReader();
                
                if (dados.HasRows) {
                    return true;
                }

            } catch (Exception err) {
                Console.WriteLine("Erro de conexão: " + err.Message);
            } finally {
                conexaoBd.Close();
            }

            return false;
        }

        public Usuario getPorId(int id) {
            string query = "SELECT * FROM usuario WHERE id = " + id + ";";

            try {
                conexaoBd.Open();
                comando = new MySqlCommand(query, conexaoBd);
                MySqlDataReader dados = comando.ExecuteReader();
                dados.Read();

                Usuario usuario = new Usuario(
                            Convert.ToInt32(dados["id"]),
                            dados["email"].ToString()!,
                            dados["senha"].ToString()!
                        );
             

                return usuario;

            } catch (Exception err) {
                Console.WriteLine("Erro de conexão: " + err.Message);
            } finally {
                conexaoBd.Close();
            }
            return null!;
        }

        public List<Usuario> getTodos() {
            List<Usuario> usuarios = new List<Usuario>();
            string query = "SELECT * FROM usuario;";

            try {
                conexaoBd.Open();
                comando = new MySqlCommand(query, conexaoBd);
                MySqlDataReader dados = comando.ExecuteReader();

                while (dados.Read()) {
                    usuarios.Add(new Usuario(
                        Convert.ToInt32(dados["id"]),
                        dados["email"].ToString()!,
                        dados["senha"].ToString()!
                    ));
                }

                return usuarios;
            } catch(Exception err) {
                Console.WriteLine("Erro de conexão: " + err.Message);
            } finally {
                conexaoBd.Close();
            }
            return null!;
        }

        private void executarComando(string query) {
            try {
                conexaoBd.Open();
                comando = new MySqlCommand(query, conexaoBd);
                comando.ExecuteReader();
            } catch (Exception err) {
                Console.WriteLine("Erro de conexão: " + err.Message);
            } finally {
                conexaoBd.Close();
            }
        }

        public Usuario getPorEmail(string email) {
            string query = "SELECT * FROM usuario WHERE email = '" + email + "';";
            Usuario usuario = null!;

            try {
                conexaoBd.Open();
                comando = new MySqlCommand(query, conexaoBd);
                MySqlDataReader dados = comando.ExecuteReader();

                if (!dados.HasRows) {
                    return null!;
                }

                dados.Read();

                usuario = new Usuario(
                            Convert.ToInt32(dados["id"]),
                            dados["email"].ToString()!,
                            dados["senha"].ToString()!
                        );


                return usuario;

            } catch (Exception err) {
                Console.WriteLine("Erro de conexão: " + err.Message);
            } finally {
                conexaoBd.Close();
            }

            return usuario;
        }
    }
}
