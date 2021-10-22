using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO_SISTEMAACADEMIA
{
    public partial class F_login : Form
    {
        Form1 form1;
        DataTable dt = new DataTable();
        public F_login(Form1 f)
        {
            form1 = f;
            InitializeComponent();
        }

        public string tipoacesso(int nivel)
        {
            if (nivel == 1)
                return Globais.acesso = "GERENTE";
            else if (nivel == 2)
               return  Globais.acesso = "MASTER";
            else
               return Globais.acesso = "ALUNO";
        }

        private void cb_mostrarsenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_mostrarsenha.Checked)
            {
                tb_senha.PasswordChar = '\u0000';
            }
            else
            {
                tb_senha.PasswordChar = '*';
            }
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string senha = tb_senha.Text;

            if(username == "" || senha == "")
            {
                MessageBox.Show("INFORME UM LOGIN");
                tb_username.Focus();
                return;
            }
            string sql = "SELECT * FROM tb_usuarios WHERE T_USERNAME='"+username+"'AND T_SENHAUSUARIO='"+senha+"'";
            dt = Banco.dql(sql);
            if(dt.Rows.Count == 1)
            {
                form1.lb_acesso.Text = dt.Rows[0].ItemArray[5].ToString();//ha duas formas de se acessar os dados
                form1.lb_nomeusuario.Text = dt.Rows[0].Field<string>("T_NOMEUSUARIO");// duas  formas de se acessar os dados do banco
                form1.pb_imagestatus.Image = Properties.Resources.acessopermitido;
                Globais.nivel = int.Parse(dt.Rows[0].Field<Int64>("N_NIVELUSUARIO").ToString());
                Globais.logado = true;
                form1.lb_nivelacesso.Text = tipoacesso(Globais.nivel);
                this.Close();
            }
            else
            {
                MessageBox.Show("USUARIO NAO ENCONTRADO");
                tb_username.Clear();
                tb_senha.Clear();
                tb_username.Focus();
            }
        }

        private void F_login_Load(object sender, EventArgs e)
        {
            tb_username.Text = "vitinho";
            tb_senha.Text = "123";
        }
    }
}
