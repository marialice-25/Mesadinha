namespace mesadinha
{
    partial class Categorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categorias));
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.txt_categoria = new System.Windows.Forms.TextBox();
            this.dgv_resultado = new System.Windows.Forms.DataGridView();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(228, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "CATEGORIAS";
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Font = new System.Drawing.Font("Georgia", 10F);
            this.lbl_categoria.ForeColor = System.Drawing.Color.White;
            this.lbl_categoria.Location = new System.Drawing.Point(153, 110);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(72, 17);
            this.lbl_categoria.TabIndex = 26;
            this.lbl_categoria.Text = "Categoria:";
            this.lbl_categoria.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_categoria
            // 
            this.txt_categoria.Location = new System.Drawing.Point(257, 107);
            this.txt_categoria.Name = "txt_categoria";
            this.txt_categoria.Size = new System.Drawing.Size(144, 20);
            this.txt_categoria.TabIndex = 27;
            // 
            // dgv_resultado
            // 
            this.dgv_resultado.BackgroundColor = System.Drawing.Color.White;
            this.dgv_resultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_resultado.Location = new System.Drawing.Point(111, 164);
            this.dgv_resultado.Name = "dgv_resultado";
            this.dgv_resultado.Size = new System.Drawing.Size(392, 137);
            this.dgv_resultado.TabIndex = 28;
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.White;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Georgia", 7F);
            this.btn_salvar.Location = new System.Drawing.Point(232, 322);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(85, 40);
            this.btn_salvar.TabIndex = 30;
            this.btn_salvar.Text = "SALVAR";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.White;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Georgia", 7F);
            this.btn_voltar.Location = new System.Drawing.Point(329, 322);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(85, 40);
            this.btn_voltar.TabIndex = 31;
            this.btn_voltar.Text = "VOLTAR";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(606, 395);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.dgv_resultado);
            this.Controls.Add(this.txt_categoria);
            this.Controls.Add(this.lbl_categoria);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Categorias";
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.Categorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.TextBox txt_categoria;
        private System.Windows.Forms.DataGridView dgv_resultado;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_voltar;
    }
}