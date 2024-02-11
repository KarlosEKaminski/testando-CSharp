namespace teste
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
            this.components = new System.ComponentModel.Container();
            this.textNumeroInicial = new System.Windows.Forms.Label();
            this.textNumeroFinal = new System.Windows.Forms.Label();
            this.botaoSeparar = new System.Windows.Forms.Button();
            this.campoNumeroInicial = new System.Windows.Forms.TextBox();
            this.campoNumeroFinal = new System.Windows.Forms.TextBox();
            this.textNumerosPares = new System.Windows.Forms.Label();
            this.textNumerosImpares = new System.Windows.Forms.Label();
            this.campoNumerosPares = new System.Windows.Forms.RichTextBox();
            this.camposNumerosImpares = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.botaoLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textNumeroInicial
            // 
            this.textNumeroInicial.AutoSize = true;
            this.textNumeroInicial.Location = new System.Drawing.Point(35, 50);
            this.textNumeroInicial.Name = "textNumeroInicial";
            this.textNumeroInicial.Size = new System.Drawing.Size(121, 13);
            this.textNumeroInicial.TabIndex = 0;
            this.textNumeroInicial.Text = "Informe o número inicial:";
            this.textNumeroInicial.Click += new System.EventHandler(this.label1_Click);
            // 
            // textNumeroFinal
            // 
            this.textNumeroFinal.AutoSize = true;
            this.textNumeroFinal.Location = new System.Drawing.Point(229, 50);
            this.textNumeroFinal.Name = "textNumeroFinal";
            this.textNumeroFinal.Size = new System.Drawing.Size(114, 13);
            this.textNumeroFinal.TabIndex = 1;
            this.textNumeroFinal.Text = "Informe o número final:";
            this.textNumeroFinal.Click += new System.EventHandler(this.label2_Click);
            // 
            // botaoSeparar
            // 
            this.botaoSeparar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.botaoSeparar.Location = new System.Drawing.Point(400, 73);
            this.botaoSeparar.Name = "botaoSeparar";
            this.botaoSeparar.Size = new System.Drawing.Size(75, 23);
            this.botaoSeparar.TabIndex = 2;
            this.botaoSeparar.Text = "Separar";
            this.botaoSeparar.UseVisualStyleBackColor = false;
            this.botaoSeparar.Click += new System.EventHandler(this.button1_Click);
            // 
            // campoNumeroInicial
            // 
            this.campoNumeroInicial.Location = new System.Drawing.Point(38, 75);
            this.campoNumeroInicial.Name = "campoNumeroInicial";
            this.campoNumeroInicial.Size = new System.Drawing.Size(135, 20);
            this.campoNumeroInicial.TabIndex = 3;
            this.campoNumeroInicial.TextChanged += new System.EventHandler(this.campoNumeroInicial_TextChanged);
            // 
            // campoNumeroFinal
            // 
            this.campoNumeroFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.campoNumeroFinal.Location = new System.Drawing.Point(232, 75);
            this.campoNumeroFinal.Name = "campoNumeroFinal";
            this.campoNumeroFinal.Size = new System.Drawing.Size(147, 20);
            this.campoNumeroFinal.TabIndex = 4;
            this.campoNumeroFinal.TextChanged += new System.EventHandler(this.campoNumeroFinal_TextChanged);
            // 
            // textNumerosPares
            // 
            this.textNumerosPares.AutoSize = true;
            this.textNumerosPares.Location = new System.Drawing.Point(35, 128);
            this.textNumerosPares.Name = "textNumerosPares";
            this.textNumerosPares.Size = new System.Drawing.Size(138, 13);
            this.textNumerosPares.TabIndex = 7;
            this.textNumerosPares.Text = "Número pares encontrados:";
            // 
            // textNumerosImpares
            // 
            this.textNumerosImpares.AutoSize = true;
            this.textNumerosImpares.Location = new System.Drawing.Point(229, 128);
            this.textNumerosImpares.Name = "textNumerosImpares";
            this.textNumerosImpares.Size = new System.Drawing.Size(153, 13);
            this.textNumerosImpares.TabIndex = 8;
            this.textNumerosImpares.Text = "Números impares encontrados:";
            // 
            // campoNumerosPares
            // 
            this.campoNumerosPares.BackColor = System.Drawing.SystemColors.Window;
            this.campoNumerosPares.ForeColor = System.Drawing.SystemColors.WindowText;
            this.campoNumerosPares.Location = new System.Drawing.Point(38, 158);
            this.campoNumerosPares.Name = "campoNumerosPares";
            this.campoNumerosPares.ReadOnly = true;
            this.campoNumerosPares.Size = new System.Drawing.Size(135, 179);
            this.campoNumerosPares.TabIndex = 9;
            this.campoNumerosPares.Text = "";
            // 
            // camposNumerosImpares
            // 
            this.camposNumerosImpares.BackColor = System.Drawing.SystemColors.Window;
            this.camposNumerosImpares.Location = new System.Drawing.Point(233, 158);
            this.camposNumerosImpares.Name = "camposNumerosImpares";
            this.camposNumerosImpares.ReadOnly = true;
            this.camposNumerosImpares.Size = new System.Drawing.Size(146, 179);
            this.camposNumerosImpares.TabIndex = 10;
            this.camposNumerosImpares.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // botaoLimpar
            // 
            this.botaoLimpar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.botaoLimpar.Location = new System.Drawing.Point(400, 123);
            this.botaoLimpar.Name = "botaoLimpar";
            this.botaoLimpar.Size = new System.Drawing.Size(75, 23);
            this.botaoLimpar.TabIndex = 12;
            this.botaoLimpar.Text = "Limpar";
            this.botaoLimpar.UseVisualStyleBackColor = false;
            this.botaoLimpar.Click += new System.EventHandler(this.botaoLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 385);
            this.Controls.Add(this.botaoLimpar);
            this.Controls.Add(this.camposNumerosImpares);
            this.Controls.Add(this.campoNumerosPares);
            this.Controls.Add(this.textNumerosImpares);
            this.Controls.Add(this.textNumerosPares);
            this.Controls.Add(this.campoNumeroFinal);
            this.Controls.Add(this.campoNumeroInicial);
            this.Controls.Add(this.botaoSeparar);
            this.Controls.Add(this.textNumeroFinal);
            this.Controls.Add(this.textNumeroInicial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programa Teste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textNumeroInicial;
        private System.Windows.Forms.Label textNumeroFinal;
        private System.Windows.Forms.Button botaoSeparar;
        private System.Windows.Forms.TextBox campoNumeroInicial;
        public System.Windows.Forms.TextBox campoNumeroFinal;
        private System.Windows.Forms.Label textNumerosPares;
        private System.Windows.Forms.Label textNumerosImpares;
        private System.Windows.Forms.RichTextBox campoNumerosPares;
        private System.Windows.Forms.RichTextBox camposNumerosImpares;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button botaoLimpar;
    }
}

