namespace ProjetoLivraria.View.Estoque
{
    partial class TelaPesquisarEstoque
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
            botao_pesquisarnome = new Button();
            texto_pesquisarnome = new TextBox();
            label9 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            texto_pesquisarcodigo = new TextBox();
            label2 = new Label();
            botao_pesquisarcodigo = new Button();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            texto_quantidade = new TextBox();
            texto_nomelivro = new TextBox();
            label4 = new Label();
            label3 = new Label();
            tabPage2 = new TabPage();
            tabControl1 = new TabControl();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // botao_pesquisarnome
            // 
            botao_pesquisarnome.Location = new Point(553, 26);
            botao_pesquisarnome.Name = "botao_pesquisarnome";
            botao_pesquisarnome.Size = new Size(75, 23);
            botao_pesquisarnome.TabIndex = 5;
            botao_pesquisarnome.Text = "Pesqusiar";
            botao_pesquisarnome.UseVisualStyleBackColor = true;
            botao_pesquisarnome.Click += botao_pesquisarnome_Click;
            // 
            // texto_pesquisarnome
            // 
            texto_pesquisarnome.Location = new Point(308, 27);
            texto_pesquisarnome.Name = "texto_pesquisarnome";
            texto_pesquisarnome.Size = new Size(200, 23);
            texto_pesquisarnome.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(83, 30);
            label9.Name = "label9";
            label9.Size = new Size(175, 21);
            label9.TabIndex = 6;
            label9.Text = "Digite o Nome do Livro:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(33, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(633, 212);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Código";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Livro";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Quantidade Atual";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Tipo Situação";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Data";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Código Funcionário";
            Column6.Name = "Column6";
            // 
            // texto_pesquisarcodigo
            // 
            texto_pesquisarcodigo.Location = new Point(308, 21);
            texto_pesquisarcodigo.Name = "texto_pesquisarcodigo";
            texto_pesquisarcodigo.Size = new Size(200, 23);
            texto_pesquisarcodigo.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(83, 24);
            label2.Name = "label2";
            label2.Size = new Size(179, 21);
            label2.TabIndex = 3;
            label2.Text = "Digite o Código do Livro";
            // 
            // botao_pesquisarcodigo
            // 
            botao_pesquisarcodigo.Location = new Point(553, 20);
            botao_pesquisarcodigo.Name = "botao_pesquisarcodigo";
            botao_pesquisarcodigo.Size = new Size(75, 23);
            botao_pesquisarcodigo.TabIndex = 2;
            botao_pesquisarcodigo.Text = "Pesqusiar";
            botao_pesquisarcodigo.UseVisualStyleBackColor = true;
            botao_pesquisarcodigo.Click += botao_pesquisarcodigo_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(texto_pesquisarcodigo);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(botao_pesquisarcodigo);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(695, 309);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Por Código";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(texto_quantidade);
            groupBox1.Controls.Add(texto_nomelivro);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(45, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(605, 205);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações do Estoque";
            // 
            // texto_quantidade
            // 
            texto_quantidade.Location = new Point(303, 120);
            texto_quantidade.Name = "texto_quantidade";
            texto_quantidade.Size = new Size(157, 23);
            texto_quantidade.TabIndex = 24;
            // 
            // texto_nomelivro
            // 
            texto_nomelivro.Location = new Point(303, 60);
            texto_nomelivro.Name = "texto_nomelivro";
            texto_nomelivro.Size = new Size(157, 23);
            texto_nomelivro.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(96, 118);
            label4.Name = "label4";
            label4.Size = new Size(179, 21);
            label4.TabIndex = 18;
            label4.Text = "Quantidade em Estoque:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(101, 58);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 17;
            label3.Text = "Livro:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(texto_pesquisarnome);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(botao_pesquisarnome);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(695, 309);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Por Nome";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(49, 94);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(703, 337);
            tabControl1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            label1.Location = new Point(262, 20);
            label1.Name = "label1";
            label1.Size = new Size(317, 47);
            label1.TabIndex = 3;
            label1.Text = "Pesquisar Estoque";
            // 
            // TelaPesquisarEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Name = "TelaPesquisarEstoque";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pesquisar Estoque";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botao_pesquisarnome;
        private TextBox texto_pesquisarnome;
        private Label label9;
        private DataGridView dataGridView1;
        private TextBox texto_pesquisarcodigo;
        private Label label2;
        private Button botao_pesquisarcodigo;
        private TabPage tabPage1;
        private GroupBox groupBox1;
        private TextBox texto_quantidade;
        private TextBox texto_nomelivro;
        private Label label4;
        private Label label3;
        private TabPage tabPage2;
        private TabControl tabControl1;
        private Label label1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}