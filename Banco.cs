using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace PROJETO_SISTEMAACADEMIA
{
    class Banco
    {
        private static SQLiteConnection conexao;

        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source="+Globais.caminhoBanco + Globais.nomeBanco);
            conexao.Open();
            return conexao;
        }
        public static DataTable ObterUsuario()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_usuario";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }catch(Exception erro)
            {
                throw erro;
            }
        }
        public static DataTable dql(string sql)//data query language;
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        public static void dml(string q, string msgOk = null, string msgErro = null) //data manipulation language(insert , delete , update);
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = q;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
                if(msgOk != null)
                {
                    MessageBox.Show(msgOk);
                }
            }
            catch (Exception erro)
            {
                if(msgErro != null)
                {
                    MessageBox.Show(msgErro + "\n" + erro.Message);
                }
                throw erro;
            }
        }
        public static void NovoUsuario(Usuario aluno)
        {
            if (existe_username(aluno))
            {
                MessageBox.Show("NAO FOI POSSIVEL CADASTRAR ! USERNAME JA EXISTE!");
                return;
            }
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_usuarios (T_NOMEUSUARIO, T_USERNAME, T_SENHAUSUARIO, T_SITUACAOUSUARIO, N_NIVELUSUARIO) VALUES (@nome, @username, @senha, @status, @nivel)";
                cmd.Parameters.AddWithValue("@nome", aluno.T_NOMEUSUARIO);
                cmd.Parameters.AddWithValue("@username", aluno.T_USERNAME);
                cmd.Parameters.AddWithValue("@senha", aluno.T_SENHAUSUARIO);
                cmd.Parameters.AddWithValue("@status", aluno.T_SITUACAOUSUARIO);
                cmd.Parameters.AddWithValue("@nivel", aluno.N_NIVELUSUARIO);
                cmd.ExecuteNonQuery();
                MessageBox.Show("NOVO USUARIO CADASTRADO");
                vcon.Close();

            }catch(Exception ex)
            {
                MessageBox.Show("ERRO AO INSERIR NOVO USUARIO");
            }
        }
        public static bool existe_username(Usuario aluno)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            var vcon = ConexaoBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT T_USERNAME FROM tb_usuarios WHERE T_USERNAME='" + aluno.T_USERNAME + "'";
            da = new SQLiteDataAdapter(cmd.CommandText, vcon);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
            vcon.Close();
        }
        public static DataTable ObterUsuarioIdNome()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT N_IDUSUARIO as 'ID USUARIO',T_NOMEUSUARIO as 'NOME USUARIO' FROM tb_usuarios";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public static DataTable ObterDadosUsuario(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_usuarios WHERE N_IDUSUARIO="+id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public static void AtualizarUsuario(Usuario aluno)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "UPDATE tb_usuarios SET T_NOMEUSUARIO='"+aluno.T_NOMEUSUARIO+ "',T_USERNAME='" + aluno.T_USERNAME + "',T_SENHAUSUARIO='" + aluno.T_SENHAUSUARIO + "',T_SITUACAOUSUARIO='" + aluno.T_SITUACAOUSUARIO + "',N_NIVELUSUARIO="+aluno.N_NIVELUSUARIO+" WHERE N_IDUSUARIO="+aluno.N_IDUSUARIO;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public static void ExcluirUsuario(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM tb_usuarios WHERE N_IDUSUARIO=" +id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
