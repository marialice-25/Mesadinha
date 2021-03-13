namespace mesadinha
{
    partial class frm_controle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_controle));
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.dgv_resultado = new System.Windows.Forms.DataGridView();
            this.txt_nomeconta = new System.Windows.Forms.TextBox();
            this.mnu_controle = new System.Windows.Forms.MenuStrip();
            this.contasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbx_tipo = new System.Windows.Forms.ComboBox();
            this.lbl_cat = new System.Windows.Forms.Label();
            this.cbx_cat = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado)).BeginInit();
            this.mnu_controle.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(239, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "CONTAS";
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Font = new System.Drawing.Font("Georgia", 10F);
            this.lbl_tipo.ForeColor = System.Drawing.Color.White;
            this.lbl_tipo.Location = new System.Drawing.Point(240, 96);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(42, 17);
            this.lbl_tipo.TabIndex = 5;
            this.lbl_tipo.Text = "Tipo:";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Georgia", 10F);
            this.lbl_nome.ForeColor = System.Drawing.Color.White;
            this.lbl_nome.Location = new System.Drawing.Point(22, 95);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(50, 17);
            this.lbl_nome.TabIndex = 6;
            this.lbl_nome.Text = "Nome:";
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.White;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Georgia", 7F);
            this.btn_salvar.Location = new System.Drawing.Point(279, 335);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(85, 40);
            this.btn_salvar.TabIndex = 20;
            this.btn_salvar.Text = "SALVAR";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // dgv_resultado
            // 
            this.dgv_resultado.BackgroundColor = System.Drawing.Color.White;
            this.dgv_resultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_resultado.Location = new System.Drawing.Point(142, 153);
            this.dgv_resultado.Name = "dgv_resultado";
            this.dgv_resultado.Size = new System.Drawing.Size(347, 164);
            this.dgv_resultado.TabIndex = 21;
            // 
            // txt_nomeconta
            // 
            this.txt_nomeconta.Location = new System.Drawing.Point(78, 94);
            this.txt_nomeconta.Name = "txt_nomeconta";
            this.txt_nomeconta.Size = new System.Drawing.Size(149, 20);
            this.txt_nomeconta.TabIndex = 23;
            // 
            // mnu_controle
            // 
            this.mnu_controle.BackColor = System.Drawing.Color.White;
            this.mnu_controle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contasToolStripMenuItem});
            this.mnu_controle.Location = new System.Drawing.Point(0, 0);
            this.mnu_controle.Name = "mnu_controle";
            this.mnu_controle.Size = new System.Drawing.Size(618, 24);
            this.mnu_controle.TabIndex = 24;
            this.mnu_controle.Text = "menu";
            this.mnu_controle.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnu_controle_ItemClicked);
            // 
            // contasToolStripMenuItem
            // 
            this.contasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movimentaçãoToolStripMenuItem,
            this.usuárioToolStripMenuItem,
            this.categoriaToolStripMenuItem});
            this.contasToolStripMenuItem.Name = "contasToolStripMenuItem";
            this.contasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.contasToolStripMenuItem.Text = "Contas";
            // 
            // movimentaçãoToolStripMenuItem
            // 
            this.movimentaçãoToolStripMenuItem.Name = "movimentaçãoToolStripMenuItem";
            this.movimentaçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.movimentaçãoToolStripMenuItem.Text = "Movimentação";
            this.movimentaçãoToolStripMenuItem.Click += new System.EventHandler(this.movimentaçãoToolStripMenuItem_Click);
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            this.usuárioToolStripMenuItem.Click += new System.EventHandler(this.usuárioToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // cbx_tipo
            // 
            this.cbx_tipo.FormattingEnabled = true;
            this.cbx_tipo.Items.AddRange(new object[] {
            "Selecione...",
            "Receita",
            "Despesa"});
            this.cbx_tipo.Location = new System.Drawing.Point(279, 93);
            this.cbx_tipo.Name = "cbx_tipo";
            this.cbx_tipo.Size = new System.Drawing.Size(114, 21);
            this.cbx_tipo.TabIndex = 29;
            // 
            // lbl_cat
            // 
            this.lbl_cat.AutoSize = true;
            this.lbl_cat.Font = new System.Drawing.Font("Georgia", 10F);
            this.lbl_cat.ForeColor = System.Drawing.Color.White;
            this.lbl_cat.Location = new System.Drawing.Point(399, 97);
            this.lbl_cat.Name = "lbl_cat";
            this.lbl_cat.Size = new System.Drawing.Size(72, 17);
            this.lbl_cat.TabIndex = 30;
            this.lbl_cat.Text = "Categoria:";
            // 
            // cbx_cat
            // 
            this.cbx_cat.FormattingEnabled = true;
            this.cbx_cat.Items.AddRange(new object[] {
            "Selecione...",
            "Receita",
            "Despesa"});
            this.cbx_cat.Location = new System.Drawing.Point(477, 93);
            this.cbx_cat.Name = "cbx_cat";
            this.cbx_cat.Size = new System.Drawing.Size(129, 21);
            this.cbx_cat.TabIndex = 31;
            // 
            // frm_controle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(618, 387);
            this.Controls.Add(this.cbx_cat);
            this.Controls.Add(this.lbl_cat);
            this.Controls.Add(this.cbx_tipo);
            this.Controls.Add(this.txt_nomeconta);
            this.Controls.Add(this.dgv_resultado);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_tipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mnu_controle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnu_controle;
            this.Name = "frm_controle";
            this.Text = "Controle";
            this.Load += new System.EventHandler(this.frm_controle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado)).EndInit();
            this.mnu_controle.ResumeLayout(false);
            this.mnu_controle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.DataGridView dgv_resultado;
        private System.Windows.Forms.TextBox txt_nomeconta;
        private System.Windows.Forms.MenuStrip mnu_controle;
        private System.Windows.Forms.ToolStripMenuItem contasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbx_tipo;
        private System.Windows.Forms.Label lbl_cat;
        private System.Windows.Forms.ComboBox cbx_cat;
    }
}