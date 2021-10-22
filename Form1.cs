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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            F_login f_login = new F_login(this);
            f_login.ShowDialog();
        }
        private void AbreForm(int nivel, Form f)
        {
            if (Globais.logado == true)
            {
                if (Globais.nivel >= nivel)
                {
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("ACESSO NEGADO ! NIVEL DE ACESSO NAO CORRESPONDIDO");
                }
            }
            else
            {
                MessageBox.Show("É NECESSÁRIO ESTAR LOGADO PARA TER ACESSO");
            }
        }
        private void lOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_login f_login = new F_login(this);
            f_login.ShowDialog();
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_acesso.Text = "0";
            lb_nomeusuario.Text = "---";
            pb_imagestatus.Image = Properties.Resources.acessonegado;
            Globais.nivel = 0;
            Globais.logado = false;
        }

        private void bANCODEDADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AbreForm();
        }

        private void nOVOUSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
            AbreForm(1, f_NovoUsuario);
        }

        private void gESTAODEUSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoUsuario f_GestaoUsuario = new F_GestaoUsuario();
            AbreForm(1, f_GestaoUsuario);
        }

        private void nOVOALUNOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NovoAluno f_NovoAluno = new F_NovoAluno();
            AbreForm(1, f_NovoAluno);
        }

        private void hORARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Horarios f_Horarios = new F_Horarios();
            AbreForm(2, f_Horarios);
        }

        private void pROFESSORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Professores f_Professores = new F_Professores();
            AbreForm(2, f_Professores);
        }

        private void gESTÃODETURMASToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void tURMASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoTurmas f_GestaoTurmas = new F_GestaoTurmas();
            AbreForm(2, f_GestaoTurmas);
        }

        private void gESTAODEALUNOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoAlunos f_GestaoAlunos = new F_GestaoAlunos();
            AbreForm(1, f_GestaoAlunos);
        }
    }   
}
