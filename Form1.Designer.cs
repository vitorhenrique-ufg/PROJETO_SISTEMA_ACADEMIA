namespace PROJETO_SISTEMAACADEMIA
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_imagestatus = new System.Windows.Forms.PictureBox();
            this.lb_nivelacesso = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_nomeusuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_acesso = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANUTENCAOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bANCODEDADOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hORARIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROFESSORESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tURMASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSUARIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nOVOUSUARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.gESTAODEUSUARIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aLUNOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nOVOALUNOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gESTAODEALUNOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagestatus)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pb_imagestatus);
            this.panel1.Controls.Add(this.lb_nivelacesso);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lb_nomeusuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lb_acesso);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 32);
            this.panel1.TabIndex = 10;
            // 
            // pb_imagestatus
            // 
            this.pb_imagestatus.Image = global::PROJETO_SISTEMAACADEMIA.Properties.Resources.acessonegado;
            this.pb_imagestatus.Location = new System.Drawing.Point(397, 0);
            this.pb_imagestatus.Name = "pb_imagestatus";
            this.pb_imagestatus.Size = new System.Drawing.Size(38, 32);
            this.pb_imagestatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_imagestatus.TabIndex = 4;
            this.pb_imagestatus.TabStop = false;
            // 
            // lb_nivelacesso
            // 
            this.lb_nivelacesso.AutoSize = true;
            this.lb_nivelacesso.Location = new System.Drawing.Point(294, 8);
            this.lb_nivelacesso.Name = "lb_nivelacesso";
            this.lb_nivelacesso.Size = new System.Drawing.Size(16, 13);
            this.lb_nivelacesso.TabIndex = 5;
            this.lb_nivelacesso.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nivel:";
            // 
            // lb_nomeusuario
            // 
            this.lb_nomeusuario.AutoSize = true;
            this.lb_nomeusuario.Location = new System.Drawing.Point(143, 9);
            this.lb_nomeusuario.Name = "lb_nomeusuario";
            this.lb_nomeusuario.Size = new System.Drawing.Size(16, 13);
            this.lb_nomeusuario.TabIndex = 3;
            this.lb_nomeusuario.Text = "---";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario:";
            // 
            // lb_acesso
            // 
            this.lb_acesso.AutoSize = true;
            this.lb_acesso.Location = new System.Drawing.Point(57, 9);
            this.lb_acesso.Name = "lb_acesso";
            this.lb_acesso.Size = new System.Drawing.Size(13, 13);
            this.lb_acesso.TabIndex = 1;
            this.lb_acesso.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Acesso: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem,
            this.mANUTENCAOToolStripMenuItem,
            this.uSUARIOSToolStripMenuItem,
            this.aLUNOSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(435, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lOGINToolStripMenuItem,
            this.sAIRToolStripMenuItem});
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.mENUToolStripMenuItem.Text = "MENU";
            // 
            // lOGINToolStripMenuItem
            // 
            this.lOGINToolStripMenuItem.Name = "lOGINToolStripMenuItem";
            this.lOGINToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.lOGINToolStripMenuItem.Text = "LOGIN";
            this.lOGINToolStripMenuItem.Click += new System.EventHandler(this.lOGINToolStripMenuItem_Click);
            // 
            // sAIRToolStripMenuItem
            // 
            this.sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            this.sAIRToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.sAIRToolStripMenuItem.Text = "SAIR";
            this.sAIRToolStripMenuItem.Click += new System.EventHandler(this.sAIRToolStripMenuItem_Click);
            // 
            // mANUTENCAOToolStripMenuItem
            // 
            this.mANUTENCAOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bANCODEDADOSToolStripMenuItem,
            this.hORARIOSToolStripMenuItem,
            this.pROFESSORESToolStripMenuItem,
            this.tURMASToolStripMenuItem});
            this.mANUTENCAOToolStripMenuItem.Name = "mANUTENCAOToolStripMenuItem";
            this.mANUTENCAOToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mANUTENCAOToolStripMenuItem.Text = "MANUTENÇÃO";
            // 
            // bANCODEDADOSToolStripMenuItem
            // 
            this.bANCODEDADOSToolStripMenuItem.Name = "bANCODEDADOSToolStripMenuItem";
            this.bANCODEDADOSToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.bANCODEDADOSToolStripMenuItem.Text = "BANCO DE DADOS";
            this.bANCODEDADOSToolStripMenuItem.Click += new System.EventHandler(this.bANCODEDADOSToolStripMenuItem_Click);
            // 
            // hORARIOSToolStripMenuItem
            // 
            this.hORARIOSToolStripMenuItem.Name = "hORARIOSToolStripMenuItem";
            this.hORARIOSToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.hORARIOSToolStripMenuItem.Text = "HORARIOS";
            this.hORARIOSToolStripMenuItem.Click += new System.EventHandler(this.hORARIOSToolStripMenuItem_Click);
            // 
            // pROFESSORESToolStripMenuItem
            // 
            this.pROFESSORESToolStripMenuItem.Name = "pROFESSORESToolStripMenuItem";
            this.pROFESSORESToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.pROFESSORESToolStripMenuItem.Text = "PROFESSORES";
            this.pROFESSORESToolStripMenuItem.Click += new System.EventHandler(this.pROFESSORESToolStripMenuItem_Click);
            // 
            // tURMASToolStripMenuItem
            // 
            this.tURMASToolStripMenuItem.Name = "tURMASToolStripMenuItem";
            this.tURMASToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.tURMASToolStripMenuItem.Text = "TURMAS";
            this.tURMASToolStripMenuItem.Click += new System.EventHandler(this.tURMASToolStripMenuItem_Click);
            // 
            // uSUARIOSToolStripMenuItem
            // 
            this.uSUARIOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nOVOUSUARIOToolStripMenuItem,
            this.toolStripMenuItem1,
            this.gESTAODEUSUARIOSToolStripMenuItem});
            this.uSUARIOSToolStripMenuItem.Name = "uSUARIOSToolStripMenuItem";
            this.uSUARIOSToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.uSUARIOSToolStripMenuItem.Text = "USUARIOS";
            // 
            // nOVOUSUARIOToolStripMenuItem
            // 
            this.nOVOUSUARIOToolStripMenuItem.Name = "nOVOUSUARIOToolStripMenuItem";
            this.nOVOUSUARIOToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.nOVOUSUARIOToolStripMenuItem.Text = "NOVO USUARIO";
            this.nOVOUSUARIOToolStripMenuItem.Click += new System.EventHandler(this.nOVOUSUARIOToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(188, 6);
            // 
            // gESTAODEUSUARIOSToolStripMenuItem
            // 
            this.gESTAODEUSUARIOSToolStripMenuItem.Name = "gESTAODEUSUARIOSToolStripMenuItem";
            this.gESTAODEUSUARIOSToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.gESTAODEUSUARIOSToolStripMenuItem.Text = "GESTÃO DE USUARIOS";
            this.gESTAODEUSUARIOSToolStripMenuItem.Click += new System.EventHandler(this.gESTAODEUSUARIOSToolStripMenuItem_Click);
            // 
            // aLUNOSToolStripMenuItem
            // 
            this.aLUNOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nOVOALUNOToolStripMenuItem,
            this.gESTAODEALUNOSToolStripMenuItem});
            this.aLUNOSToolStripMenuItem.Name = "aLUNOSToolStripMenuItem";
            this.aLUNOSToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.aLUNOSToolStripMenuItem.Text = "ALUNOS";
            // 
            // nOVOALUNOToolStripMenuItem
            // 
            this.nOVOALUNOToolStripMenuItem.Name = "nOVOALUNOToolStripMenuItem";
            this.nOVOALUNOToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.nOVOALUNOToolStripMenuItem.Text = "NOVO ALUNO";
            this.nOVOALUNOToolStripMenuItem.Click += new System.EventHandler(this.nOVOALUNOToolStripMenuItem_Click);
            // 
            // gESTAODEALUNOSToolStripMenuItem
            // 
            this.gESTAODEALUNOSToolStripMenuItem.Name = "gESTAODEALUNOSToolStripMenuItem";
            this.gESTAODEALUNOSToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.gESTAODEALUNOSToolStripMenuItem.Text = "GESTAO DE ALUNOS";
            this.gESTAODEALUNOSToolStripMenuItem.Click += new System.EventHandler(this.gESTAODEALUNOSToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(435, 109);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Academs";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagestatus)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lb_nomeusuario;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lb_acesso;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox pb_imagestatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mANUTENCAOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bANCODEDADOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSUARIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nOVOUSUARIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gESTAODEUSUARIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aLUNOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nOVOALUNOToolStripMenuItem;
        public System.Windows.Forms.Label lb_nivelacesso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem hORARIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROFESSORESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tURMASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gESTAODEALUNOSToolStripMenuItem;
    }
}

