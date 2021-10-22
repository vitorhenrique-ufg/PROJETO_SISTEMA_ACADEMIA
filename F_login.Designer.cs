namespace PROJETO_SISTEMAACADEMIA
{
    partial class F_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_login));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.lkb_cadastrar = new System.Windows.Forms.LinkLabel();
            this.cb_mostrarsenha = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(140, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "ACADEMS LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "USERNAME";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(158, 135);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(125, 20);
            this.tb_username.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "SENHA";
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(158, 184);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(125, 20);
            this.tb_senha.TabIndex = 12;
            // 
            // btn_entrar
            // 
            this.btn_entrar.Location = new System.Drawing.Point(250, 226);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(98, 45);
            this.btn_entrar.TabIndex = 13;
            this.btn_entrar.Text = "ENTRAR";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // lkb_cadastrar
            // 
            this.lkb_cadastrar.AutoSize = true;
            this.lkb_cadastrar.Location = new System.Drawing.Point(142, 226);
            this.lkb_cadastrar.Name = "lkb_cadastrar";
            this.lkb_cadastrar.Size = new System.Drawing.Size(73, 13);
            this.lkb_cadastrar.TabIndex = 14;
            this.lkb_cadastrar.TabStop = true;
            this.lkb_cadastrar.Text = "CADASTRAR";
            // 
            // cb_mostrarsenha
            // 
            this.cb_mostrarsenha.AutoSize = true;
            this.cb_mostrarsenha.Location = new System.Drawing.Point(289, 187);
            this.cb_mostrarsenha.Name = "cb_mostrarsenha";
            this.cb_mostrarsenha.Size = new System.Drawing.Size(95, 17);
            this.cb_mostrarsenha.TabIndex = 15;
            this.cb_mostrarsenha.Text = "Mostrar Senha";
            this.cb_mostrarsenha.UseVisualStyleBackColor = true;
            this.cb_mostrarsenha.CheckedChanged += new System.EventHandler(this.cb_mostrarsenha_CheckedChanged);
            // 
            // F_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(477, 336);
            this.Controls.Add(this.cb_mostrarsenha);
            this.Controls.Add(this.lkb_cadastrar);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Academs";
            this.Load += new System.EventHandler(this.F_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.LinkLabel lkb_cadastrar;
        private System.Windows.Forms.CheckBox cb_mostrarsenha;
    }
}