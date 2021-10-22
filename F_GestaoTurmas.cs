using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace PROJETO_SISTEMAACADEMIA
{
    public partial class F_GestaoTurmas : Form
    {
        string idSelecionado;
        int modo = 0; //0 - padrao / 1 - edicao / 2 - insercao
        string vqueryDGV = "";
        public F_GestaoTurmas()
        {
            InitializeComponent();
        }

        private void F_GestaoTurmas_Load(object sender, EventArgs e)
        {
            vqueryDGV = @"
                SELECT 
                    N_IDTURMA as 'ID',
                    T_DSCTURMA as 'TURMA',
                    T_DSCHORARIO as 'HORARIO'
                FROM
                    tb_turmas as tbt
                INNER JOIN
                    tb_horarios as tbh on tbh.N_IDHORARIO = tbt.N_IDHORARIO
            ";
            dgv_turmas.DataSource = Banco.dql(vqueryDGV);
            dgv_turmas.Columns[0].Width = 40;
            dgv_turmas.Columns[1].Width = 120;
            dgv_turmas.Columns[2].Width = 85;
            // POPULAR COMBOBOX PROFESSORES//
            string vqueryProfessores = @"
                SELECT 
                    N_IDPROFESSOR,
                    T_NOMEPROFESSOR
                FROM
                    tb_professores
                ORDER BY
                    T_NOMEPROFESSOR
            ";
            cb_professor.Items.Clear();
            cb_professor.DataSource = Banco.dql(vqueryProfessores);
            cb_professor.DisplayMember = "T_NOMEPROFESSOR";
            cb_professor.ValueMember = "N_IDPROFESSOR";

            //POPULAR COMBOBOX STATUS(ATIVA - A / PARALISADA - P / CANCELADA - C//
            Dictionary<string, string> st = new Dictionary<string, string>();
            st.Add("A","ATIVA");
            st.Add("P","PARALISADA");
            st.Add("C","CANCELADA");
            cb_status.Items.Clear();
            cb_status.DataSource = new BindingSource(st,null);
            cb_status.DisplayMember = "VALUE" ;
            cb_status.ValueMember = "KEY";

            //POPULAR COMBOBOX HORARIO//
            string vqueryHorario = @"
                SELECT 
                    *
                FROM
                    tb_horarios
                ORDER BY
                    T_DSCHORARIO
            ";
            cb_horario.Items.Clear();
            cb_horario.DataSource = Banco.dql(vqueryHorario);
            cb_horario.DisplayMember = "T_DSCHORARIO";
            cb_horario.ValueMember = "N_IDHORARIO";
        }

        private void dgv_turmas_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;
            if(contlinhas > 0)
            {
                modo = 0;
                idSelecionado = dgv_turmas.SelectedRows[0].Cells[0].Value.ToString();
                string vqueryCampos = @"
                    SELECT
                        T_DSCTURMA,
                        N_IDPROFESSOR,
                        N_IDHORARIO,
                        N_MAXIMOALUNOS,
                        T_STATUS
                    FROM
                        tb_turmas
                    WHERE
                        N_IDTURMA=" + idSelecionado;
                DataTable dt = Banco.dql(vqueryCampos);
                cb_professor.SelectedValue = dt.Rows[0].Field<Int64>("N_IDPROFESSOR").ToString();
                n_MaxAlunos.Value = dt.Rows[0].Field<Int64>("N_MAXIMOALUNOS");
                cb_status.SelectedValue = dt.Rows[0].Field<string>("T_STATUS");
                cb_horario.SelectedValue = dt.Rows[0].Field<Int64>("N_IDHORARIO");
                tb_dscturma.Text = dt.Rows[0].Field<string>("T_DSCTURMA");

                tb_vagas.Text = calcVagas();
            }
        }

        private string calcVagas()
        {
            DataTable dt = new DataTable();
            string queryVagas = String.Format(@"
                    SELECT 
                        count(N_IDALUNO) as 'contVagas'
                    FROM
                        tb_alunos
                    WHERE
                        T_STATUS='A' and N_IDTURMA={0}", idSelecionado);
            dt = Banco.dql(queryVagas);
            int vagas = Int32.Parse(Math.Round(n_MaxAlunos.Value, 0).ToString());
            vagas -= Int32.Parse(dt.Rows[0].Field<Int64>("contVagas").ToString());
            return vagas.ToString();
        }

        private void btn_novaturma_Click(object sender, EventArgs e)
        {
            tb_dscturma.Clear();
            cb_professor.SelectedIndex = -1;
            n_MaxAlunos.Value = 0;
            cb_status.SelectedIndex = -1;
            cb_horario.SelectedIndex = -1;
            tb_dscturma.Focus();
            modo = 2;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {

            string queryAtualizarTurma = "";
            string msg = "";
            if (modo == 1)
            {
                queryAtualizarTurma = String.Format(@"
                UPDATE 
                    tb_turmas
                SET
                    T_DSCTURMA='{0}',
                    N_IDPROFESSOR={1},
                    N_IDHORARIO={2},
                    N_MAXIMOALUNOS={3},
                    T_STATUS='{4}'
                WHERE
                    N_IDTURMA={5}", tb_dscturma.Text, cb_professor.SelectedValue, cb_horario.SelectedValue, Int32.Parse(Math.Round(n_MaxAlunos.Value, 0).ToString()), cb_status.SelectedValue, idSelecionado);
                msg = "EDIÇÃO REALIZADA COM SUCESSO !";
            }
            else
            {
                queryAtualizarTurma = String.Format(@"
                       INSERT INTO tb_turmas
                       (T_DSCTURMA, N_IDPROFESSOR, N_IDHORARIO, N_MAXIMOALUNOS, T_STATUS)
                       VALUES('{0}',{1},{2},{3},'{4}')", tb_dscturma.Text, cb_professor.SelectedValue, cb_horario.SelectedValue, Int32.Parse(Math.Round(n_MaxAlunos.Value, 0).ToString()), cb_status.SelectedValue);
                msg = "NOVA TURMA INSERIDA COM SUCESSO !";
            }
            MessageBox.Show(msg);
            int linha = dgv_turmas.SelectedRows[0].Index;
            Banco.dml(queryAtualizarTurma);
            if (modo == 1)
            {
                dgv_turmas[1, linha].Value = tb_dscturma.Text;
                dgv_turmas[2, linha].Value = cb_horario.Text;
                tb_vagas.Text = calcVagas();
            }
            else
            {
                dgv_turmas.DataSource = Banco.dql(vqueryDGV);  
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("VOCE DESEJA REALMENTE EXCLUIR?", "EXCLUIR", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                string queryExcluirTurma = String.Format(@"
                    DELETE
                    FROM
                        tb_turmas
                    WHERE
                        N_IDTURMA={0}",idSelecionado);
                Banco.dml(queryExcluirTurma);
                dgv_turmas.Rows.Remove(dgv_turmas.CurrentRow);
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tb_dscturma_TextChanged(object sender, EventArgs e)
        {
            if(modo == 0)
                modo = 1;
        }

        private void cb_professor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modo == 0)
                modo = 1;
        }

        private void n_MaxAlunos_ValueChanged(object sender, EventArgs e)
        {
            if (modo == 0)
                modo = 1;
        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modo == 0)
                modo = 1;
        }

        private void cb_horario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modo == 0)
                modo = 1;
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            string nomeArquivo = Globais.caminho + @"\turmas.pdf";
            FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
            Document doc = new Document(PageSize.A4);
            PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);

            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Globais.caminho + @"\logo.jpg");
            logo.ScaleToFit(160f, 130f);
            logo.SetAbsolutePosition(100f, 700f); //X / Y;
            //logo.Alignment = Element.ALIGN_LEFT; // OUTRA FORMA DE POSICIONAR A FOTO


            string dados = "";
            Paragraph paragrafo1 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20,(int)System.Drawing.FontStyle.Bold));
            paragrafo1.Alignment = Element.ALIGN_CENTER;
            paragrafo1.Add("Relatorios de Turmas\n\n");
            

            PdfPTable tabela = new PdfPTable(3);
            tabela.DefaultCell.FixedHeight = 20;

            tabela.AddCell("ID Turma");
            tabela.AddCell("Turma");
            tabela.AddCell("Horario");

            DataTable dtTurmas = Banco.dql(vqueryDGV);

            for(int i = 0; i < dtTurmas.Rows.Count; i++)
            {
                tabela.AddCell(dtTurmas.Rows[i].Field<Int64>("ID").ToString());
                tabela.AddCell(dtTurmas.Rows[i].Field<string>("Turma"));
                tabela.AddCell(dtTurmas.Rows[i].Field<string>("Horario"));
            }

            doc.Open();
            doc.Add(paragrafo1);
            doc.Add(tabela);
            doc.Add(logo);
            doc.Close();

            DialogResult res = MessageBox.Show("Deseja Abrir o Relatório?", "Relatório", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(Globais.caminho + @"\turmas.pdf");
            }
        }
    }   
}
