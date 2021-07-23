using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Loja.DTO;

namespace Loja.DAL
{
    public class UsuarioDAL
    {
        string strSql = "";
        public IList<usuario_DTO> cargaUsuario()
        {
            strSql = "select * from tb_usuarios";

            SqlConnection sqlCon = new SqlConnection(SQLHelper.ObterConnectionString());

            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            try
            {
                sqlCon.Open();

                SqlDataReader reader;
                IList<usuario_DTO> listUsuarioDTO = new List<usuario_DTO>();

                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while(reader.Read())
                    {
                        usuario_DTO usuario = new usuario_DTO();

                        usuario.cod_usuario = Convert.ToInt32(reader["cod_usuario"]);
                        usuario.perfil = Convert.ToInt32(reader["perfil"]);
                        usuario.cadastro = Convert.ToDateTime(reader["cadastro"]);
                        usuario.nome = Convert.ToString(reader["nome"]);
                        usuario.email = Convert.ToString(reader["email"]);
                        usuario.login = Convert.ToString(reader["login"]);
                        usuario.senha = Convert.ToString(reader["senha"]);
                        usuario.situacao = Convert.ToString(reader["situacao"]);

                        listUsuarioDTO.Add(usuario);
                    }
                }
                return listUsuarioDTO;
            }
            catch (Exception ex)
            {
                throw ex;
                
            }
            finally
            {
                sqlCon.Close();
            }
        }

        public bool inserirUsuario(usuario_DTO usuario)
        {
            strSql = "insert into tb_usuarios (nome, login, email, senha, cadastro, situacao, perfil) values (@nome, @login, @email, @senha, @cadastro, @situacao, @perfil)";

            
            try
            {
                SqlConnection sqlCon = new SqlConnection(SQLHelper.ObterConnectionString());

                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                comando.Parameters.Add("@nome", System.Data.SqlDbType.VarChar).Value = usuario.nome;
                comando.Parameters.Add("@login", System.Data.SqlDbType.VarChar).Value = usuario.login;
                comando.Parameters.Add("@email", System.Data.SqlDbType.VarChar).Value = usuario.email;
                comando.Parameters.Add("@senha", System.Data.SqlDbType.VarChar).Value = usuario.senha;
                comando.Parameters.Add("@cadastro", System.Data.SqlDbType.DateTime).Value = usuario.cadastro;
                comando.Parameters.Add("@situacao", System.Data.SqlDbType.Char,1).Value = usuario.situacao;
                comando.Parameters.Add("@perfil", System.Data.SqlDbType.Int).Value = usuario.perfil;

                sqlCon.Open();

                comando.ExecuteNonQuery();

                return true;
            
            } catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool alterarUsuario(usuario_DTO usuario)
        {
            strSql = "update tb_usuarios set nome = @nome, login = @login, email = @email, senha = @senha, cadastro = @cadastro, situacao = @situacao, perfil = @perfil where cod_usuario = @cod_usuario";

            try
            {
                SqlConnection sqlCon = new SqlConnection(SQLHelper.ObterConnectionString());

                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                comando.Parameters.Add("@nome", System.Data.SqlDbType.VarChar).Value = usuario.nome;
                comando.Parameters.Add("@login", System.Data.SqlDbType.VarChar).Value = usuario.login;
                comando.Parameters.Add("@email", System.Data.SqlDbType.VarChar).Value = usuario.email;
                comando.Parameters.Add("@senha", System.Data.SqlDbType.VarChar).Value = usuario.senha;
                comando.Parameters.Add("@cadastro", System.Data.SqlDbType.DateTime).Value = usuario.cadastro;
                comando.Parameters.Add("@situacao", System.Data.SqlDbType.Char, 1).Value = usuario.situacao;
                comando.Parameters.Add("@perfil", System.Data.SqlDbType.Int).Value = usuario.perfil;
                comando.Parameters.Add("@cod_usuario", System.Data.SqlDbType.Int).Value = usuario.cod_usuario;

                sqlCon.Open();

                comando.ExecuteNonQuery();

                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool excluirUsuario(int cod_usuario)
        {
            strSql = "delete from tb_usuarios where cod_usuario = @cod_usuario";

            try { 
                SqlConnection sqlCon = new SqlConnection(SQLHelper.ObterConnectionString());

                SqlCommand comando = new SqlCommand(strSql, sqlCon);

                comando.Parameters.Add("@cod_usuario", System.Data.SqlDbType.Int).Value = cod_usuario;

                sqlCon.Open();
                comando.ExecuteNonQuery();
                return true;
            } 
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
