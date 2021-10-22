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
    public partial class F_Horarios : Form
    {
        public F_Horarios()
        {
            InitializeComponent();
        }

        private void F_Horarios_Load(object sender, EventArgs e)
        {
            string vquery = @"
                SELECT 
                    N_IDHORARIO as 'ID',
                    T_DSCHORARIO as 'HORARIO'
               FROM
                    tb_horarios
                ORDER BY
                    T_DSCHORARIO
            ";
            dgv_horarios.DataSource = Banco.dql(vquery);
            dgv_horarios.Columns[0].Width = 60;
            dgv_horarios.Columns[1].Width = 180;
        }

        private void dgv_horarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;
            if(contlinhas > 0)
            {
                DataTable dt = new DataTable();
                string id = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string vquery = @"
                    SELECT 
                        *
                    FROM
                        tb_horarios
                    WHERE
                        N_IDHORARIO=" + id;
                dt = Banco.dql(vquery);
                tb_idhorario.Text = dt.Rows[0].Field<Int64>("N_IDHORARIO").ToString();
                mtb_dscHorario.Text = dt.Rows[0].Field<string>("T_DSCHORARIO");
            }
        }

        private void btn_novohorario_Click(object sender, EventArgs e)
        {
            tb_idhorario.Clear();
            mtb_dscHorario.Clear();
            mtb_dscHorario.Focus();
        }

        private void btn_salvarhorario_Click(object sender, EventArgs e)
        {
            string vquery = "";
            if (tb_idhorario.Text == "")
            {
                vquery = "INSERT INTO tb_horarios (T_DSCHORARIO) VALUES ('" + mtb_dscHorario.Text + "')";
            }
            else
            {
                vquery = "UPDATE  tb_horarios SET T_DSCHORARIO='" + mtb_dscHorario.Text + "'WHERE N_IDHORARIO=" + tb_idhorario.Text;
            }
             Banco.dml(vquery);
             vquery = @"
                SELECT 
                    N_IDHORARIO as 'ID',
                    T_DSCHORARIO as 'HORARIO'
               FROM
                    tb_horarios
              ORDER BY
                    T_DSCHORARIO
            ";
            dgv_horarios.DataSource = Banco.dql(vquery);
            dgv_horarios.Columns[0].Width = 60;
            dgv_horarios.Columns[1].Width = 180;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("VOCE DEJEJA REALMENTE EXCLUIR O HORARIO?", "EXCLUIR", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                string vquery = "DELETE FROM tb_horarios WHERE N_IDHORARIO=" + tb_idhorario.Text;
                Banco.dml(vquery);
                dgv_horarios.Rows.Remove(dgv_horarios.CurrentRow);
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
