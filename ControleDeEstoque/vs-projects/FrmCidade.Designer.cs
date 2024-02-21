namespace ControleDeEstoque
{
    partial class FrmCidade
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
            label1 = new Label();
            text_buscado = new TextBox();
            txt_populacaoDe = new TextBox();
            label2 = new Label();
            cbo_Uf = new ComboBox();
            btn_buscar = new Button();
            txt_populacaoAte = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-2, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1111, 419);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 24);
            label1.Name = "label1";
            label1.Size = new Size(65, 21);
            label1.TabIndex = 1;
            label1.Text = "Buscar:";
            // 
            // text_buscado
            // 
            text_buscado.Location = new Point(91, 25);
            text_buscado.Name = "text_buscado";
            text_buscado.Size = new Size(271, 23);
            text_buscado.TabIndex = 2;
            text_buscado.TextChanged += text_buscado_TextChanged;
            // 
            // txt_populacaoDe
            // 
            txt_populacaoDe.Location = new Point(511, 29);
            txt_populacaoDe.Name = "txt_populacaoDe";
            txt_populacaoDe.Size = new Size(74, 23);
            txt_populacaoDe.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(391, 27);
            label2.Name = "label2";
            label2.Size = new Size(114, 21);
            label2.TabIndex = 3;
            label2.Text = "População de";
            // 
            // cbo_Uf
            // 
            cbo_Uf.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_Uf.FormattingEnabled = true;
            cbo_Uf.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cbo_Uf.Location = new Point(780, 29);
            cbo_Uf.Name = "cbo_Uf";
            cbo_Uf.Size = new Size(121, 23);
            cbo_Uf.TabIndex = 7;
            // 
            // btn_buscar
            // 
            btn_buscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_buscar.Location = new Point(963, 27);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(86, 25);
            btn_buscar.TabIndex = 8;
            btn_buscar.Text = "Busca";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // txt_populacaoAte
            // 
            txt_populacaoAte.Location = new Point(649, 29);
            txt_populacaoAte.Name = "txt_populacaoAte";
            txt_populacaoAte.Size = new Size(74, 23);
            txt_populacaoAte.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(607, 28);
            label3.Name = "label3";
            label3.Size = new Size(36, 21);
            label3.TabIndex = 9;
            label3.Text = "Até";
            // 
            // FrmCidade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 602);
            Controls.Add(txt_populacaoAte);
            Controls.Add(label3);
            Controls.Add(btn_buscar);
            Controls.Add(cbo_Uf);
            Controls.Add(txt_populacaoDe);
            Controls.Add(label2);
            Controls.Add(text_buscado);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FrmCidade";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta de cidades";
            Load += FrmCidade_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox text_buscado;
        private TextBox txt_populacaoDe;
        private Label label2;
        private ComboBox cbo_Uf;
        private Button btn_buscar;
        private TextBox txt_populacaoAte;
        private Label label3;
    }
}