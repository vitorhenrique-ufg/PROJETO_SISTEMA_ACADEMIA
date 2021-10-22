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
    public partial class F_GestaoUsuario : Form
    {
        public F_GestaoUsuario()
        {
            InitializeComponent();
        }

        private void F_GestaoUsuario_Load(object sender, EventArgs e)
        {
            dgv_usuarios.DataSource = Banco.ObterUsuarioIdNome();
            dgv_usuarios.Columns[0].Width = 80;
            dgv_usuarios.Columns[1].Width = 200;
        }

        private void dgv_usuarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;
            DataTable dt = new DataTable();
            if(contlinhas > 0)
            {
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterDadosUsuario(vid);
                tb_id.Text = dt.Rows[0].Field<Int64>("N_IDUSUARIO").ToString();
                tb_nome.Text = dt.Rows[0].Field<string>("T_NOMEUSUARIO").ToString();
                tb_username.Text = dt.Rows[0].Field<string>("T_USERNAME").ToString();
                tb_senha.Text = dt.Rows[0].Field<string>("T_SENHAUSUARIO").ToString();
                cb_status.Text = dt.Rows[0].Field<string>("T_SITUACAOUSUARIO").ToString();
                n_nivel.Value = dt.Rows[0].Field<Int64>("N_NIVELUSUARIO");
            }
         }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
            f_NovoUsuario.ShowDialog();
            dgv_usuarios.DataSource = Banco.ObterUsuarioIdNome();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            int linha = dgv_usuarios.SelectedRows[0].Index;
            Usuario aluno = new Usuario();
            aluno.N_IDUSUARIO = Convert.ToInt32(tb_id.Text);
            aluno.T_NOMEUSUARIO = tb_nome.Text;
            aluno.T_USERNAME = tb_username.Text;
            aluno.T_SENHAUSUARIO = tb_senha.Text;
            aluno.T_SITUACAOUSUARIO = cb_status.Text;
            aluno.N_NIVELUSUARIO = Convert.ToInt32(Math.Round(n_nivel.Value,0));
            Banco.AtualizarUsuario(aluno);
            dgv_usuarios[1, linha].Value = tb_nome.Text;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("VOCE DESEJA REALMENTE EXCLUIR ESSE ALUNO?", "EXCLUIR", MessageBoxButtons.YesNo);
            
            if(res == DialogResult.Yes)
            {
                Banco.ExcluirUsuario(tb_id.Text);
                dgv_usuarios.Rows.Remove(dgv_usuarios.CurrentRow);
            }
        }
    }
}
