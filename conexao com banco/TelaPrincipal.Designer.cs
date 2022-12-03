namespace conexao_com_banco
{
    partial class TelaPrincipal
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
            this.btnalimenticio = new System.Windows.Forms.Button();
            this.btnfornecedor = new System.Windows.Forms.Button();
            this.btnproduto = new System.Windows.Forms.Button();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnalimenticio);
            this.panel1.Controls.Add(this.btnfornecedor);
            this.panel1.Controls.Add(this.btnproduto);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 526);
            this.panel1.TabIndex = 0;
            // 
            // btnalimenticio
            // 
            this.btnalimenticio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalimenticio.Location = new System.Drawing.Point(3, 340);
            this.btnalimenticio.Name = "btnalimenticio";
            this.btnalimenticio.Size = new System.Drawing.Size(159, 100);
            this.btnalimenticio.TabIndex = 2;
            this.btnalimenticio.Text = "Alimenticio";
            this.btnalimenticio.UseVisualStyleBackColor = true;
            this.btnalimenticio.Click += new System.EventHandler(this.btnalimenticio_Click);
            // 
            // btnfornecedor
            // 
            this.btnfornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfornecedor.Location = new System.Drawing.Point(0, 196);
            this.btnfornecedor.Name = "btnfornecedor";
            this.btnfornecedor.Size = new System.Drawing.Size(162, 100);
            this.btnfornecedor.TabIndex = 1;
            this.btnfornecedor.Text = "Fornecedor";
            this.btnfornecedor.UseVisualStyleBackColor = true;
            this.btnfornecedor.Click += new System.EventHandler(this.btnfornecedor_Click);
            // 
            // btnproduto
            // 
            this.btnproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproduto.Location = new System.Drawing.Point(0, 46);
            this.btnproduto.Name = "btnproduto";
            this.btnproduto.Size = new System.Drawing.Size(162, 100);
            this.btnproduto.TabIndex = 0;
            this.btnproduto.Text = "Produto";
            this.btnproduto.UseVisualStyleBackColor = true;
            this.btnproduto.Click += new System.EventHandler(this.btnproduto_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Location = new System.Drawing.Point(168, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(760, 526);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 525);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.panel1);
            this.Name = "TelaPrincipal";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnalimenticio;
        private System.Windows.Forms.Button btnfornecedor;
        private System.Windows.Forms.Button btnproduto;
        private System.Windows.Forms.Panel pnlPrincipal;
    }
}

