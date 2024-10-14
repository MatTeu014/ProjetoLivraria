namespace ProjetoLivraria.View.Pedido
{
    partial class TelaCadastrarPedido
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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            texto_codigolivro = new TextBox();
            numerico_quantidade = new NumericUpDown();
            botao_registrar = new Button();
            label3 = new Label();
            texto_total = new TextBox();
            botao_finalizar = new Button();
            botao_cancelar = new Button();
            label4 = new Label();
            label5 = new Label();
            texto_codigocliente = new TextBox();
            texto_funcionario = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numerico_quantidade).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(28, 145);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(737, 252);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Código";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Quantidade";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Valor Unitário";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Total";
            Column4.Name = "Column4";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 61);
            label1.Name = "label1";
            label1.Size = new Size(139, 15);
            label1.TabIndex = 1;
            label1.Text = "Digite o Código do Livro:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(337, 61);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 2;
            label2.Text = "Quantidade:";
            // 
            // texto_codigolivro
            // 
            texto_codigolivro.Location = new Point(195, 58);
            texto_codigolivro.Name = "texto_codigolivro";
            texto_codigolivro.Size = new Size(125, 23);
            texto_codigolivro.TabIndex = 3;
            // 
            // numerico_quantidade
            // 
            numerico_quantidade.Location = new Point(415, 59);
            numerico_quantidade.Name = "numerico_quantidade";
            numerico_quantidade.Size = new Size(137, 23);
            numerico_quantidade.TabIndex = 4;
            // 
            // botao_registrar
            // 
            botao_registrar.Location = new Point(670, 50);
            botao_registrar.Name = "botao_registrar";
            botao_registrar.Size = new Size(93, 36);
            botao_registrar.TabIndex = 5;
            botao_registrar.Text = "Registrar";
            botao_registrar.UseVisualStyleBackColor = true;
            botao_registrar.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(595, 406);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 6;
            label3.Text = "Valor Total:";
            // 
            // texto_total
            // 
            texto_total.Location = new Point(665, 403);
            texto_total.Name = "texto_total";
            texto_total.Size = new Size(100, 23);
            texto_total.TabIndex = 7;
            // 
            // botao_finalizar
            // 
            botao_finalizar.Location = new Point(633, 432);
            botao_finalizar.Name = "botao_finalizar";
            botao_finalizar.Size = new Size(132, 36);
            botao_finalizar.TabIndex = 8;
            botao_finalizar.Text = "Finalizar Compra";
            botao_finalizar.UseVisualStyleBackColor = true;
            // 
            // botao_cancelar
            // 
            botao_cancelar.Location = new Point(28, 432);
            botao_cancelar.Name = "botao_cancelar";
            botao_cancelar.Size = new Size(93, 36);
            botao_cancelar.TabIndex = 9;
            botao_cancelar.Text = "Cancelar";
            botao_cancelar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 20);
            label4.Name = "label4";
            label4.Size = new Size(150, 15);
            label4.TabIndex = 10;
            label4.Text = "Digite o Código do Cliente:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(337, 17);
            label5.Name = "label5";
            label5.Size = new Size(176, 15);
            label5.TabIndex = 11;
            label5.Text = "Digite o Código do Funcionário:";
            // 
            // texto_codigocliente
            // 
            texto_codigocliente.Location = new Point(206, 14);
            texto_codigocliente.Name = "texto_codigocliente";
            texto_codigocliente.Size = new Size(114, 23);
            texto_codigocliente.TabIndex = 12;
            // 
            // texto_funcionario
            // 
            texto_funcionario.Location = new Point(519, 14);
            texto_funcionario.Name = "texto_funcionario";
            texto_funcionario.Size = new Size(114, 23);
            texto_funcionario.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(90, 98);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(230, 23);
            dateTimePicker1.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 104);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 15;
            label6.Text = "Data:";
            // 
            // TelaCadastrarPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 494);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(texto_funcionario);
            Controls.Add(texto_codigocliente);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(botao_cancelar);
            Controls.Add(botao_finalizar);
            Controls.Add(texto_total);
            Controls.Add(label3);
            Controls.Add(botao_registrar);
            Controls.Add(numerico_quantidade);
            Controls.Add(texto_codigolivro);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "TelaCadastrarPedido";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Pedidos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numerico_quantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox texto_codigolivro;
        private NumericUpDown numerico_quantidade;
        private Button botao_registrar;
        private Label label3;
        private TextBox texto_total;
        private Button botao_finalizar;
        private Button botao_cancelar;
        private Label label4;
        private Label label5;
        private TextBox texto_codigocliente;
        private TextBox texto_funcionario;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DateTimePicker dateTimePicker1;
        private Label label6;
    }
}