namespace PROJETO_SISTEMAACADEMIA
{
    partial class F_Horarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_idhorario = new System.Windows.Forms.TextBox();
            this.btn_novohorario = new System.Windows.Forms.Button();
            this.btn_salvarhorario = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_horarios = new System.Windows.Forms.DataGridView();
            this.mtb_dscHorario = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // tb_idhorario
            // 
            this.tb_idhorario.Location = new System.Drawing.Point(12, 25);
            this.tb_idhorario.Name = "tb_idhorario";
            this.tb_idhorario.ReadOnly = true;
            this.tb_idhorario.Size = new System.Drawing.Size(100, 20);
            this.tb_idhorario.TabIndex = 1;
            this.tb_idhorario.TabStop = false;
            // 
            // btn_novohorario
            // 
            this.btn_novohorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novohorario.Location = new System.Drawing.Point(3, -1);
            this.btn_novohorario.Name = "btn_novohorario";
            this.btn_novohorario.Size = new System.Drawing.Size(118, 23);
            this.btn_novohorario.TabIndex = 3;
            this.btn_novohorario.Text = "Novo Horario";
            this.btn_novohorario.UseVisualStyleBackColor = true;
            this.btn_novohorario.Click += new System.EventHandler(this.btn_novohorario_Click);
            // 
            // btn_salvarhorario
            // 
            this.btn_salvarhorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvarhorario.Location = new System.Drawing.Point(127, -1);
            this.btn_salvarhorario.Name = "btn_salvarhorario";
            this.btn_salvarhorario.Size = new System.Drawing.Size(138, 23);
            this.btn_salvarhorario.TabIndex = 4;
            this.btn_salvarhorario.Text = "Salvar Horario";
            this.btn_salvarhorario.UseVisualStyleBackColor = true;
            this.btn_salvarhorario.Click += new System.EventHandler(this.btn_salvarhorario_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluir.Location = new System.Drawing.Point(271, -1);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(139, 23);
            this.btn_excluir.TabIndex = 5;
            this.btn_excluir.Text = "Excluir Horario";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar.Location = new System.Drawing.Point(416, 0);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(135, 23);
            this.btn_fechar.TabIndex = 6;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Horario";
            // 
            // dgv_horarios
            // 
            this.dgv_horarios.AllowUserToAddRows = false;
            this.dgv_horarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_horarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_horarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_horarios.EnableHeadersVisualStyles = false;
            this.dgv_horarios.Location = new System.Drawing.Point(3, 51);
            this.dgv_horarios.MultiSelect = false;
            this.dgv_horarios.Name = "dgv_horarios";
            this.dgv_horarios.ReadOnly = true;
            this.dgv_horarios.RowHeadersVisible = false;
            this.dgv_horarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_horarios.Size = new System.Drawing.Size(560, 252);
            this.dgv_horarios.TabIndex = 8;
            this.dgv_horarios.SelectionChanged += new System.EventHandler(this.dgv_horarios_SelectionChanged);
            // 
            // mtb_dscHorario
            // 
            this.mtb_dscHorario.Location = new System.Drawing.Point(144, 25);
            this.mtb_dscHorario.Mask = "99:99 \\ate 99:99";
            this.mtb_dscHorario.Name = "mtb_dscHorario";
            this.mtb_dscHorario.Size = new System.Drawing.Size(100, 20);
            this.mtb_dscHorario.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_novohorario);
            this.panel1.Controls.Add(this.btn_salvarhorario);
            this.panel1.Controls.Add(this.btn_excluir);
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 309);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 25);
            this.panel1.TabIndex = 10;
            // 
            // F_Horarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 334);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mtb_dscHorario);
            this.Controls.Add(this.dgv_horarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_idhorario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Horarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horarios";
            this.Load += new System.EventHandler(this.F_Horarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_idhorario;
        private System.Windows.Forms.Button btn_novohorario;
        private System.Windows.Forms.Button btn_salvarhorario;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_horarios;
        private System.Windows.Forms.MaskedTextBox mtb_dscHorario;
        private System.Windows.Forms.Panel panel1;
    }
}