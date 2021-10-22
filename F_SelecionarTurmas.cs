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
    public partial class F_SelecionarTurmas : Form
    {
        F_NovoAluno formNovoAluno;
        public F_SelecionarTurmas(F_NovoAluno f)
        {
            formNovoAluno = f;
            InitializeComponent();
        }

        private void F_SelecionarTurmas_Load(object sender, EventArgs e)
        {
            string queryTurma = String.Format(@"
                SELECT
                    tbt.N_IDTURMA as 'ID',
                    tbt.T_DSCTURMA as 'TURMA',
                    tbh.T_DSCHORARIO as 'HORARIO',
                    tbp.T_NOMEPROFESSOR as 'PROFESSOR',
                    tbt.N_MAXIMOALUNOS as 'MAX.ALUNOS',
                    ( SELECT 
                        count (N_IDALUNO)
                       FROM
                           tb_alunos as tba
                        WHERE
                            tba.N_IDTURMA = tbt.N_IDTURMA and T_STATUS = 'A'
                    ) as 'Qtde.Alunos'
                FROM
                    tb_turmas as tbt
                INNER JOIN
                    tb_professores as tbp on tbp.N_IDPROFESSOR = tbt.N_IDPROFESSOR
                INNER JOIN
                    tb_horarios as tbh on tbh.N_IDHORARIO = tbt.N_IDHORARIO

            ");
            dgv_turmas.DataSource = Banco.dql(queryTurma);
        }

        private void dgv_turmas_DoubleClick(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int maxAlunos = 0;
            int qteAlunos = 0;
            maxAlunos = Int32.Parse(dgv.SelectedRows[0].Cells[4].Value.ToString());
            qteAlunos = Int32.Parse(dgv.SelectedRows[0].Cells[5].Value.ToString());
            if(qteAlunos >= maxAlunos)
            {
                MessageBox.Show("NAO HÁ VAGAS NESSA TURMA");

            }
            else
            {
                formNovoAluno.tb_turma.Text = dgv.Rows[dgv.SelectedRows[0].Index].Cells[1].Value.ToString();
                formNovoAluno.tb_turma.Tag = dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString();
                Close();
            }
        }
    }
}
