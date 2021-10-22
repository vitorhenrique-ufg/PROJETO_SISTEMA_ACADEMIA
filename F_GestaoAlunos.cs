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
    public partial class F_GestaoAlunos : Form
    {
        string vqueryDGV = "";
        string turmasAtual = "";
        string idSelecionado = "";
        string turma = "";
        int linha = 0;
        string origemCompleto = "";
        string foto = "";
        string pastaDestino = Globais.caminhoFotos;
        string destinoCompleto = "";
        int contPerm = 0;

        public F_GestaoAlunos()
        {
            InitializeComponent();
        }

        private void F_GestaoAlunos_Load(object sender, EventArgs e)
        {
            vqueryDGV = @"
                SELECT
                    N_IDALUNO as 'ID',
                    T_NOMEALUNO as 'ALUNO' 
                FROM
                    tb_alunos
            ";
            dgv_alunos.DataSource = Banco.dql(vqueryDGV);
            dgv_alunos.Columns[0].Width = 40;
            dgv_alunos.Columns[1].Width = 120;

            tb_nome.Text = dgv_alunos.Rows[dgv_alunos.SelectedRows[0].Index].Cells[1].Value.ToString();
            string vqueryTurmas = @"
                SELECT
                    N_IDTURMA,
                    ('Vagas: ' || (
                                    (N_MAXIMOALUNOS)-(
                                                        SELECT
                                                            count(tba.N_IDALUNO)
                                                        FROM
                                                            tb_alunos as tba
                                                        WHERE
                                                            tba.T_STATUS='A' and tba.N_IDTURMA = N_IDTURMA
                                                      )
                                    ) || ' / Turma: ' || T_DSCTURMA
                    ) as 'Turma'
                FROM
                    tb_turmas
                ORDER BY
                    N_IDTURMA
            ";

            cb_turmas.Items.Clear();
            cb_turmas.DataSource = Banco.dql(vqueryTurmas);
            cb_turmas.DisplayMember = "Turma";
            cb_turmas.ValueMember = "N_IDTURMA";

            Dictionary<string, string> status = new Dictionary<string, string>();
            status.Add("A", "ATIVO");
            status.Add("B", "BLOQUEADO");
            status.Add("C", "CANCELADO");

            cb_status.DataSource = new BindingSource(status, null);
            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "Key";
            turma = cb_turmas.Text;
            idSelecionado = dgv_alunos.Rows[0].Cells[0].Value.ToString();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_salvaredicoes_Click(object sender, EventArgs e)
        {
            turma = cb_turmas.Text;
            if ((turmasAtual != turma) || (contPerm != 0))
            {
                string[] t = turma.Split(' ');
                int vagas = int.Parse(t[1]);
                if (vagas < 1)
                {
                    MessageBox.Show("NAO HA VAGAS NA TURMA SELECIONADA, SELECIONE OUTRA OUTRA");
                    cb_turmas.Focus();
                    return;
                }
                linha = dgv_alunos.SelectedRows[0].Index;
                string queryAtualizaAluno = String.Format(@"
                    UPDATE
                        tb_alunos
                    SET
                        T_NOMEALUNO='{0}',
                        T_TELEFONE='{1}',
                        T_STATUS='{2}',
                        N_IDTURMA='{3}'
                    WHERE
                        N_IDALUNO={4}
                ", tb_nome.Text, mtb_telefone.Text, cb_status.SelectedValue, cb_turmas.SelectedValue, idSelecionado); 
                Banco.dml(queryAtualizaAluno);
                string atualizaDT =
                    @"SELECT
                        N_IDALUNO as 'ID',
                        T_NOMEALUNO as 'ALUNO'
                    FROM
                        tb_alunos
                    ORDER BY
                        N_IDALUNO
                   ";
                dgv_alunos.DataSource = Banco.dql(atualizaDT);
                MessageBox.Show("EDIÇÕES ALTERADAS COM SUCESSO !");
                turmasAtual = cb_turmas.Text;
                contPerm = 0;
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("CONFIRMAR EXCLUSÃO", "EXCLUIR", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (File.Exists(pb_foto.ImageLocation))
                {
                    File.Delete(pb_foto.ImageLocation);
                }
                string vqueryExcluirAluno = String.Format(@"
                    DELETE FROM
                        tb_alunos
                    WHERE
                        N_IDALUNO={0}
                ", idSelecionado);
                Banco.dml(vqueryExcluirAluno);
                dgv_alunos.Rows.Remove(dgv_alunos.CurrentRow);
            }
        }

        private void dgv_alunos_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if(dgv.SelectedRows.Count > 0)
            {
                idSelecionado = dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString();
                tb_nome.Text = dgv_alunos.Rows[dgv_alunos.SelectedRows[0].Index].Cells[1].Value.ToString();
                idSelecionado = dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString();
                string vqueryCampos = String.Format(@"
                    SELECT
                        N_IDALUNO,
                        T_NOMEALUNO,
                        T_TELEFONE,
                        T_STATUS,
                        N_IDTURMA,
                        T_FOTO
                    FROM
                        tb_alunos
                    WHERE
                        N_IDALUNO={0}
                ",idSelecionado);
                DataTable dt = Banco.dql(vqueryCampos);
                tb_nome.Text = dt.Rows[0].Field<string>("T_NOMEALUNO");
                mtb_telefone.Text = dt.Rows[0].Field<string>("T_TELEFONE");
                cb_status.SelectedValue = dt.Rows[0].Field<string>("T_STATUS");
                cb_turmas.SelectedValue = dt.Rows[0].Field<Int64>("N_IDTURMA");
                turma = cb_turmas.Text;
                pb_foto.ImageLocation = dt.Rows[0].Field<string>("T_FOTO");
            }
        }

        private void pb_foto_Click(object sender, EventArgs e)
        {
           
            if (pb_foto.ImageLocation == null)
            {
                pastaDestino = Globais.caminhoFotos;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    origemCompleto = openFileDialog1.FileName; // caminho do arquivo + nome do arquivo
                    foto = openFileDialog1.SafeFileName; // somente o nome do arquivo
                    destinoCompleto = pastaDestino + foto;
                }
                if (File.Exists(destinoCompleto))
                {
                    if (MessageBox.Show("ARQUIVO JA EXISTE ! DESEJA SUBSTITUIR?", "SUBSTITUIR", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
                System.IO.File.Copy(origemCompleto, destinoCompleto, true);
                if (File.Exists(destinoCompleto))
                {
                    pb_foto.ImageLocation = destinoCompleto;
                }
                else
                {
                    MessageBox.Show("ARQUIVO NAO COPIADO");
                }
                string vqueryAtualizaFoto = String.Format(@"
                    UPDATE
                        tb_alunos
                    SET
                        T_NOMEALUNO='{0}',
                        T_TELEFONE='{1}',
                        T_STATUS='{2}',  
                        N_IDTURMA='{3}',
                        T_FOTO='{4}'
                   WHERE
                        N_IDALUNO={5}
                ",tb_nome.Text, mtb_telefone.Text, cb_status.SelectedValue, cb_turmas.SelectedValue, destinoCompleto,idSelecionado);
                Banco.dml(vqueryAtualizaFoto);
                MessageBox.Show("FOTO ALTERADA COM SUCESSO !");
            }
            else
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    origemCompleto = openFileDialog1.FileName; // caminho do arquivo + nome do arquivo
                    foto = openFileDialog1.SafeFileName; // somente o nome do arquivo
                    destinoCompleto = pastaDestino + foto;
                }
                if (File.Exists(destinoCompleto))
                {
                    if (MessageBox.Show("ARQUIVO JA EXISTE ! DESEJA SUBSTITUIR?", "SUBSTITUIR", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
                File.Delete(pb_foto.ImageLocation);
                string queryAtualizaFoto = String.Format(@"
                    UPDATE
                        tb_alunos
                    SET
                        T_FOTO='{0}'
                    WHERE
                        N_IDALUNO={1}
                    ",destinoCompleto,idSelecionado);
                Banco.dml(queryAtualizaFoto);
                System.IO.File.Copy(origemCompleto, destinoCompleto, true);
                pb_foto.ImageLocation = destinoCompleto;
                MessageBox.Show("FOTO ALTERADA COM SUCESSO!");
            }
        }

        private void tb_nome_TextChanged(object sender, EventArgs e)
        {
            contPerm = 1;
        }

        private void mtb_telefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            contPerm = 1;
        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            contPerm = 1;
        }

        private void mtb_telefone_ModifiedChanged(object sender, EventArgs e)
        {
            contPerm = 1;
        }
    }
}