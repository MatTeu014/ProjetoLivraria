namespace ProjetoLivraria.View.Book
{
    partial class TelaCadastrarLivro
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
            texto_valor = new TextBox();
            botao_cadastrar = new Button();
            texto_autor = new TextBox();
            texto_categoria = new TextBox();
            texto_nome = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // texto_valor
            // 
            texto_valor.Location = new Point(344, 307);
            texto_valor.Name = "texto_valor";
            texto_valor.Size = new Size(180, 23);
            texto_valor.TabIndex = 19;
            // 
            // botao_cadastrar
            // 
            botao_cadastrar.Location = new Point(594, 377);
            botao_cadastrar.Name = "botao_cadastrar";
            botao_cadastrar.Size = new Size(113, 43);
            botao_cadastrar.TabIndex = 18;
            botao_cadastrar.Text = "Cadastrar";
            botao_cadastrar.UseVisualStyleBackColor = true;
            botao_cadastrar.Click += botao_cadastrar_Click;
            // 
            // texto_autor
            // 
            texto_autor.Location = new Point(344, 260);
            texto_autor.Name = "texto_autor";
            texto_autor.Size = new Size(180, 23);
            texto_autor.TabIndex = 17;
            // 
            // texto_categoria
            // 
            texto_categoria.Location = new Point(344, 206);
            texto_categoria.Name = "texto_categoria";
            texto_categoria.Size = new Size(180, 23);
            texto_categoria.TabIndex = 16;
            // 
            // texto_nome
            // 
            texto_nome.Location = new Point(344, 154);
            texto_nome.Name = "texto_nome";
            texto_nome.Size = new Size(180, 23);
            texto_nome.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(209, 305);
            label5.Name = "label5";
            label5.Size = new Size(49, 21);
            label5.TabIndex = 14;
            label5.Text = "Valor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(209, 258);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 13;
            label4.Text = "Autor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(209, 204);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 12;
            label3.Text = "Categoria:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(209, 152);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 11;
            label2.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            label1.Location = new Point(209, 34);
            label1.Name = "label1";
            label1.Size = new Size(324, 47);
            label1.TabIndex = 10;
            label1.Text = "Cadastro de Livros";
            // 
            // TelaCadastrarLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(texto_valor);
            Controls.Add(botao_cadastrar);
            Controls.Add(texto_autor);
            Controls.Add(texto_categoria);
            Controls.Add(texto_nome);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaCadastrarLivro";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Livros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox texto_valor;
        private Button botao_cadastrar;
        private TextBox texto_autor;
        private TextBox texto_categoria;
        private TextBox texto_nome;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}