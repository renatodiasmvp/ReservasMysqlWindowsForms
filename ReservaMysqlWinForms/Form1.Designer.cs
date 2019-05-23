namespace ReservaMysqlWinForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDataEntrada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataSaida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.chkSolteiro = new System.Windows.Forms.CheckBox();
            this.chkCasal = new System.Windows.Forms.CheckBox();
            this.chkCompartilhado = new System.Windows.Forms.CheckBox();
            this.btnAbreOutroForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data de Entrada";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDataEntrada
            // 
            this.txtDataEntrada.Location = new System.Drawing.Point(131, 50);
            this.txtDataEntrada.Name = "txtDataEntrada";
            this.txtDataEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtDataEntrada.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data de Saída";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDataSaida
            // 
            this.txtDataSaida.Location = new System.Drawing.Point(387, 50);
            this.txtDataSaida.Name = "txtDataSaida";
            this.txtDataSaida.Size = new System.Drawing.Size(100, 20);
            this.txtDataSaida.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(524, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor Total";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(598, 49);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(100, 20);
            this.txtValorTotal.TabIndex = 5;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(34, 93);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 6;
            this.btnIncluir.Text = "INCLUIR";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // dgvReservas
            // 
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(34, 142);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.Size = new System.Drawing.Size(754, 150);
            this.dgvReservas.TabIndex = 7;
            // 
            // chkSolteiro
            // 
            this.chkSolteiro.AutoSize = true;
            this.chkSolteiro.Location = new System.Drawing.Point(350, 97);
            this.chkSolteiro.Name = "chkSolteiro";
            this.chkSolteiro.Size = new System.Drawing.Size(61, 17);
            this.chkSolteiro.TabIndex = 8;
            this.chkSolteiro.Text = "Solteiro";
            this.chkSolteiro.UseVisualStyleBackColor = true;
            this.chkSolteiro.CheckedChanged += new System.EventHandler(this.chkSolteiro_CheckedChanged);
            // 
            // chkCasal
            // 
            this.chkCasal.AutoSize = true;
            this.chkCasal.Location = new System.Drawing.Point(452, 97);
            this.chkCasal.Name = "chkCasal";
            this.chkCasal.Size = new System.Drawing.Size(52, 17);
            this.chkCasal.TabIndex = 9;
            this.chkCasal.Text = "Casal";
            this.chkCasal.UseVisualStyleBackColor = true;
            this.chkCasal.CheckedChanged += new System.EventHandler(this.chkCasal_CheckedChanged);
            // 
            // chkCompartilhado
            // 
            this.chkCompartilhado.AutoSize = true;
            this.chkCompartilhado.Location = new System.Drawing.Point(538, 97);
            this.chkCompartilhado.Name = "chkCompartilhado";
            this.chkCompartilhado.Size = new System.Drawing.Size(93, 17);
            this.chkCompartilhado.TabIndex = 10;
            this.chkCompartilhado.Text = "Compartilhado";
            this.chkCompartilhado.UseVisualStyleBackColor = true;
            this.chkCompartilhado.CheckedChanged += new System.EventHandler(this.chkCompartilhado_CheckedChanged);
            // 
            // btnAbreOutroForm
            // 
            this.btnAbreOutroForm.Location = new System.Drawing.Point(131, 93);
            this.btnAbreOutroForm.Name = "btnAbreOutroForm";
            this.btnAbreOutroForm.Size = new System.Drawing.Size(145, 23);
            this.btnAbreOutroForm.TabIndex = 11;
            this.btnAbreOutroForm.Text = "ABRE OUTRO FORM";
            this.btnAbreOutroForm.UseVisualStyleBackColor = true;
            this.btnAbreOutroForm.Click += new System.EventHandler(this.btnAbreOutroForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAbreOutroForm);
            this.Controls.Add(this.chkCompartilhado);
            this.Controls.Add(this.chkCasal);
            this.Controls.Add(this.chkSolteiro);
            this.Controls.Add(this.dgvReservas);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDataSaida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDataEntrada);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDataEntrada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDataSaida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.CheckBox chkSolteiro;
        private System.Windows.Forms.CheckBox chkCasal;
        private System.Windows.Forms.CheckBox chkCompartilhado;
        private System.Windows.Forms.Button btnAbreOutroForm;
    }
}

