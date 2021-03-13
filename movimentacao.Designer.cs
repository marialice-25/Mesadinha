namespace mesadinha
{
    partial class movimentacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(movimentacao));
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_resultado = new System.Windows.Forms.DataGridView();
            this.cbx_conta = new System.Windows.Forms.ComboBox();
            this.btn_salvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(201, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "MOVIMENTAÇÃO";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Georgia", 10F);
            this.lbl_nome.ForeColor = System.Drawing.Color.White;
            this.lbl_nome.Location = new System.Drawing.Point(302, 115);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(47, 17);
            this.lbl_nome.TabIndex = 7;
            this.lbl_nome.Text = "Valor:";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(355, 112);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(144, 20);
            this.txt_valor.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Conta:";
            // 
            // dgv_resultado
            // 
            this.dgv_resultado.BackgroundColor = System.Drawing.Color.White;
            this.dgv_resultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_resultado.Location = new System.Drawing.Point(96, 169);
            this.dgv_resultado.Name = "dgv_resultado";
            this.dgv_resultado.Size = new System.Drawing.Size(392, 152);
            this.dgv_resultado.TabIndex = 27;
            // 
            // cbx_conta
            // 
            this.cbx_conta.FormattingEnabled = true;
            this.cbx_conta.Location = new System.Drawing.Point(118, 113);
            this.cbx_conta.Name = "cbx_conta";
            this.cbx_conta.Size = new System.Drawing.Size(159, 21);
            this.cbx_conta.TabIndex = 28;
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.White;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Georgia", 7F);
            this.btn_salvar.Location = new System.Drawing.Point(264, 342);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(85, 40);
            this.btn_salvar.TabIndex = 29;
            this.btn_salvar.Text = "SALVAR";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // movimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(580, 403);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.cbx_conta);
            this.Controls.Add(this.dgv_resultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "movimentacao";
            this.Text = "Movimentação";
            this.Load += new System.EventHandler(this.movimentacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_resultado;
        private System.Windows.Forms.ComboBox cbx_conta;
        private System.Windows.Forms.Button btn_salvar;
    }
}