namespace mesadinha
{
    partial class frm_gerenciamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_gerenciamento));
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.lbl_confirma = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_end = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_confirma = new System.Windows.Forms.TextBox();
            this.dgv_resultado = new System.Windows.Forms.DataGridView();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.White;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Georgia", 7F);
            this.btn_buscar.Location = new System.Drawing.Point(478, 361);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(85, 40);
            this.btn_buscar.TabIndex = 21;
            this.btn_buscar.Text = "BUSCAR";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.White;
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.Font = new System.Drawing.Font("Georgia", 7F);
            this.btn_excluir.Location = new System.Drawing.Point(200, 361);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(85, 40);
            this.btn_excluir.TabIndex = 22;
            this.btn_excluir.Text = "EXCLUIR";
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.BackColor = System.Drawing.Color.White;
            this.btn_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alterar.Font = new System.Drawing.Font("Georgia", 7F);
            this.btn_alterar.Location = new System.Drawing.Point(338, 361);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(85, 40);
            this.btn_alterar.TabIndex = 23;
            this.btn_alterar.Text = "ALTERAR";
            this.btn_alterar.UseVisualStyleBackColor = false;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.BackColor = System.Drawing.Color.White;
            this.btn_novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novo.Font = new System.Drawing.Font("Georgia", 7F);
            this.btn_novo.Location = new System.Drawing.Point(54, 361);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(85, 40);
            this.btn_novo.TabIndex = 24;
            this.btn_novo.Text = "NOVO";
            this.btn_novo.UseVisualStyleBackColor = false;
            this.btn_novo.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Georgia", 10F);
            this.lbl_nome.ForeColor = System.Drawing.Color.White;
            this.lbl_nome.Location = new System.Drawing.Point(51, 45);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(50, 17);
            this.lbl_nome.TabIndex = 25;
            this.lbl_nome.Text = "Nome:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Georgia", 10F);
            this.lbl_email.ForeColor = System.Drawing.Color.White;
            this.lbl_email.Location = new System.Drawing.Point(53, 89);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(48, 17);
            this.lbl_email.TabIndex = 26;
            this.lbl_email.Text = "Email:";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Font = new System.Drawing.Font("Georgia", 10F);
            this.lbl_telefone.ForeColor = System.Drawing.Color.White;
            this.lbl_telefone.Location = new System.Drawing.Point(53, 129);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(68, 17);
            this.lbl_telefone.TabIndex = 27;
            this.lbl_telefone.Text = "Telefone:";
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.Font = new System.Drawing.Font("Georgia", 10F);
            this.lbl_endereco.ForeColor = System.Drawing.Color.White;
            this.lbl_endereco.Location = new System.Drawing.Point(269, 42);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(72, 17);
            this.lbl_endereco.TabIndex = 28;
            this.lbl_endereco.Text = "Endereço:";
            this.lbl_endereco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Font = new System.Drawing.Font("Georgia", 10F);
            this.lbl_senha.ForeColor = System.Drawing.Color.White;
            this.lbl_senha.Location = new System.Drawing.Point(310, 89);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(50, 17);
            this.lbl_senha.TabIndex = 29;
            this.lbl_senha.Text = "Senha:";
            // 
            // lbl_confirma
            // 
            this.lbl_confirma.AutoSize = true;
            this.lbl_confirma.Font = new System.Drawing.Font("Georgia", 10F);
            this.lbl_confirma.ForeColor = System.Drawing.Color.White;
            this.lbl_confirma.Location = new System.Drawing.Point(269, 129);
            this.lbl_confirma.Name = "lbl_confirma";
            this.lbl_confirma.Size = new System.Drawing.Size(116, 17);
            this.lbl_confirma.TabIndex = 30;
            this.lbl_confirma.Text = "Confirmar senha:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(109, 42);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(143, 20);
            this.txt_nome.TabIndex = 31;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(109, 86);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(195, 20);
            this.txt_email.TabIndex = 32;
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(127, 126);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(136, 20);
            this.txt_tel.TabIndex = 33;
            // 
            // txt_end
            // 
            this.txt_end.Location = new System.Drawing.Point(347, 39);
            this.txt_end.Name = "txt_end";
            this.txt_end.Size = new System.Drawing.Size(216, 20);
            this.txt_end.TabIndex = 34;
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(366, 86);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(197, 20);
            this.txt_senha.TabIndex = 35;
            // 
            // txt_confirma
            // 
            this.txt_confirma.Location = new System.Drawing.Point(390, 128);
            this.txt_confirma.Name = "txt_confirma";
            this.txt_confirma.Size = new System.Drawing.Size(173, 20);
            this.txt_confirma.TabIndex = 36;
            // 
            // dgv_resultado
            // 
            this.dgv_resultado.BackgroundColor = System.Drawing.Color.White;
            this.dgv_resultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_resultado.Location = new System.Drawing.Point(54, 173);
            this.dgv_resultado.Name = "dgv_resultado";
            this.dgv_resultado.Size = new System.Drawing.Size(509, 162);
            this.dgv_resultado.TabIndex = 37;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Georgia", 10F);
            this.lbl_id.ForeColor = System.Drawing.Color.White;
            this.lbl_id.Location = new System.Drawing.Point(51, 9);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(28, 17);
            this.lbl_id.TabIndex = 38;
            this.lbl_id.Text = "ID:";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(94, 6);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(89, 20);
            this.txt_id.TabIndex = 39;
            // 
            // frm_gerenciamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(598, 435);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.dgv_resultado);
            this.Controls.Add(this.txt_confirma);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_end);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_confirma);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_endereco);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_buscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_gerenciamento";
            this.Text = "Gerenciamento de usuário";
            this.Load += new System.EventHandler(this.frm_gerenciamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_endereco;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Label lbl_confirma;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.TextBox txt_end;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_confirma;
        private System.Windows.Forms.DataGridView dgv_resultado;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_id;
    }
}