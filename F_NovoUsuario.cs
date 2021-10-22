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
    public partial class F_NovoUsuario : Form
    {
        public F_NovoUsuario()
        {
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Usuario aluno = new Usuario();
            aluno.T_NOMEUSUARIO = tb_nome.Text;
            aluno.T_USERNAME = tb_username.Text;
            aluno.T_SENHAUSUARIO = tb_senha.Text;
            aluno.T_SITUACAOUSUARIO = cb_status.Text;
            aluno.N_NIVELUSUARIO = Convert.ToInt32(Math.Round(n_nivel.Value, 0));
            Banco.NovoUsuario(aluno);
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            tb_nome.Clear();
            tb_username.Clear();
            tb_senha.Clear();
            cb_status.Text = "";
            n_nivel.Value = 0;
            tb_nome.Focus();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            tb_nome.Clear();
            tb_username.Clear();
            tb_senha.Clear();
            cb_status.Text = "";
            n_nivel.Value = 0;
            tb_nome.Focus();
        }
    }
}
