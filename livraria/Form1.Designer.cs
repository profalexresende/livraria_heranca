
namespace livraria
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
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbProduto
            // 
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Items.AddRange(new object[] {
            "Livro",
            "CD",
            "DVD"});
            this.cmbProduto.Location = new System.Drawing.Point(23, 39);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(187, 21);
            this.cmbProduto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione o Produto:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(23, 126);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(187, 23);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(23, 184);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(187, 23);
            this.btnVender.TabIndex = 3;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(23, 155);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(187, 23);
            this.btnComprar.TabIndex = 4;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(23, 213);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(187, 23);
            this.btnListar.TabIndex = 5;
            this.btnListar.Text = "Listar Produto";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 254);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbProduto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnListar;
    }
}

