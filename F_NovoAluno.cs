using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PROJETO_SISTEMAACADEMIA
{
    public partial class F_NovoAluno : Form
    {
        string origemCompleto = "";
        string foto = "";
        string pastaDestino = Globais.caminhoFotos;
        string destinoCompleto = "";
        public F_NovoAluno()
        {
            InitializeComponent();
        }

        private void F_NovoAluno_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> status = new Dictionary<string, string>();
            status.Add("A", "ATIVO");
            status.Add("B", "BLOQUEADO");
            status.Add("C", "CANCELADO");

            cb_status.DataSource = new BindingSource(status, null);
            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "Key";


        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            tb_nome.Enabled = true;
            mtb_telefone.Enabled = true;
            cb_status.Enabled = true;

            tb_nome.Clear();
            mtb_telefone.Clear();
            tb_turma.Clear();
            cb_status.SelectedIndex = 0;
            tb_nome.Focus();
            
            btn_gravar.Enabled = true;
            btn_cancelar.Enabled = true;
            btn_novo.Enabled = false;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            tb_nome.Enabled = false;
            mtb_telefone.Enabled = false;
            cb_status.Enabled = false;

            tb_nome.Clear();
            mtb_telefone.Clear();
            tb_turma.Clear();
            cb_status.SelectedIndex = 0;

            btn_gravar.Enabled = false;
            btn_cancelar.Enabled = false;
            btn_novo.Enabled = true;
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            if(destinoCompleto == "")
            {
                if(MessageBox.Show("SEM FOTO SELECIONADA, DESEJA CONTINUAR?","SEM FOTO",MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            if(destinoCompleto != "") {
                System.IO.File.Copy(origemCompleto, destinoCompleto, true);
                if (File.Exists(destinoCompleto))
                {
                    pb_fotos.ImageLocation = destinoCompleto;
                }
                else
                {
                    if (MessageBox.Show("ERRO AO LOCALIZAR FOTO, DESEJA CONTINUAR?", "ERRO", MessageBoxButtons.YesNo) == DialogResult.No)
                        return;
                }
            }

            string queryInsertAluno = String.Format(@"
                INSERT INTO tb_alunos
                        (T_NOMEALUNO, T_TELEFONE, T_STATUS, N_IDTURMA,T_FOTO)
                        VALUES('{0}','{1}','{2}',{3},'{4}')
            ",tb_nome.Text, mtb_telefone.Text, cb_status.SelectedValue, tb_turma.Tag.ToString(),destinoCompleto);

            Banco.dml(queryInsertAluno);
            MessageBox.Show("NOVO ALUNO CADASTRADO COM SUCESSO !");

            tb_nome.Enabled = false;
            mtb_telefone.Enabled = false;
            cb_status.Enabled = false;

            btn_gravar.Enabled = false;
            btn_cancelar.Enabled = false;
            btn_novo.Enabled = true;
            
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_selTurma_Click(object sender, EventArgs e)
        {
            F_SelecionarTurmas f_SelecionarTurmas = new F_SelecionarTurmas(this);
            f_SelecionarTurmas.ShowDialog();
        }

        private void btn_addfoto_Click(object sender, EventArgs e)
        {
             origemCompleto = "";
             foto = "";
             pastaDestino = Globais.caminhoFotos;
             destinoCompleto = "";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                origemCompleto = openFileDialog1.FileName; // caminho do arquivo + nome do arquivo
                foto = openFileDialog1.SafeFileName; // somente o nome do arquivo
                destinoCompleto = pastaDestino + foto;
            }
            if (File.Exists(destinoCompleto))
            {
                if(MessageBox.Show("ARQUIVO JA EXISTE ! DESEJA SUBSTITUIR?","SUBSTITUIR",MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return; 
                }
            }
            System.IO.File.Copy(origemCompleto, destinoCompleto, true);
            if (File.Exists(destinoCompleto))
            {
                pb_fotos.ImageLocation = destinoCompleto;
            }
            else
            {
                MessageBox.Show("ARQUIVO NAO COPIADO");
            }
        }
    }
}
