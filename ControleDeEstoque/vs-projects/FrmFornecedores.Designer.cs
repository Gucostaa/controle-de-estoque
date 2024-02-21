namespace ControleDeEstoque
{
    partial class FrmFornecedores
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
            tab_fornecedor = new TabControl();
            tabDados = new TabPage();
            dataGridView1 = new DataGridView();
            btn_excluir = new Button();
            btn_editar = new Button();
            btn_novo = new Button();
            tabForm = new TabPage();
            label3 = new Label();
            cbo_tipo = new ComboBox();
            chk_ativo = new CheckBox();
            label8 = new Label();
            cbo_uf = new ComboBox();
            label7 = new Label();
            txt_cidade = new TextBox();
            label6 = new Label();
            txt_bairro = new TextBox();
            label5 = new Label();
            txt_endereco = new TextBox();
            label4 = new Label();
            mask_cpnj = new MaskedTextBox();
            label2 = new Label();
            txt_nome = new TextBox();
            label1 = new Label();
            txt_id = new TextBox();
            btn_cancelar = new Button();
            btn_salvar = new Button();
            btn_fechar = new Button();
            tab_fornecedor.SuspendLayout();
            tabDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabForm.SuspendLayout();
            SuspendLayout();
            // 
            // tab_fornecedor
            // 
            tab_fornecedor.Controls.Add(tabDados);
            tab_fornecedor.Controls.Add(tabForm);
            tab_fornecedor.Location = new Point(12, 12);
            tab_fornecedor.Name = "tab_fornecedor";
            tab_fornecedor.SelectedIndex = 0;
            tab_fornecedor.Size = new Size(880, 471);
            tab_fornecedor.TabIndex = 4;
            // 
            // tabDados
            // 
            tabDados.Controls.Add(dataGridView1);
            tabDados.Controls.Add(btn_excluir);
            tabDados.Controls.Add(btn_editar);
            tabDados.Controls.Add(btn_novo);
            tabDados.Location = new Point(4, 24);
            tabDados.Name = "tabDados";
            tabDados.Padding = new Padding(3);
            tabDados.Size = new Size(872, 443);
            tabDados.TabIndex = 0;
            tabDados.Text = "Dados";
            tabDados.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(872, 396);
            dataGridView1.TabIndex = 6;
            // 
            // btn_excluir
            // 
            btn_excluir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_excluir.Location = new Point(505, 402);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(92, 36);
            btn_excluir.TabIndex = 4;
            btn_excluir.Text = "Excluir";
            btn_excluir.UseVisualStyleBackColor = true;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // btn_editar
            // 
            btn_editar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_editar.Location = new Point(380, 402);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(92, 36);
            btn_editar.TabIndex = 3;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = true;
            btn_editar.Click += btn_editar_Click;
            // 
            // btn_novo
            // 
            btn_novo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_novo.Location = new Point(253, 402);
            btn_novo.Name = "btn_novo";
            btn_novo.Size = new Size(92, 36);
            btn_novo.TabIndex = 2;
            btn_novo.Text = "Novo";
            btn_novo.UseVisualStyleBackColor = true;
            btn_novo.Click += btn_novo_Click;
            // 
            // tabForm
            // 
            tabForm.Controls.Add(label3);
            tabForm.Controls.Add(cbo_tipo);
            tabForm.Controls.Add(chk_ativo);
            tabForm.Controls.Add(label8);
            tabForm.Controls.Add(cbo_uf);
            tabForm.Controls.Add(label7);
            tabForm.Controls.Add(txt_cidade);
            tabForm.Controls.Add(label6);
            tabForm.Controls.Add(txt_bairro);
            tabForm.Controls.Add(label5);
            tabForm.Controls.Add(txt_endereco);
            tabForm.Controls.Add(label4);
            tabForm.Controls.Add(mask_cpnj);
            tabForm.Controls.Add(label2);
            tabForm.Controls.Add(txt_nome);
            tabForm.Controls.Add(label1);
            tabForm.Controls.Add(txt_id);
            tabForm.Controls.Add(btn_cancelar);
            tabForm.Controls.Add(btn_salvar);
            tabForm.Location = new Point(4, 24);
            tabForm.Name = "tabForm";
            tabForm.Padding = new Padding(3);
            tabForm.Size = new Size(872, 443);
            tabForm.TabIndex = 1;
            tabForm.Text = "Cadastro";
            tabForm.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(174, 296);
            label3.Name = "label3";
            label3.Size = new Size(36, 17);
            label3.TabIndex = 51;
            label3.Text = "Tipo";
            // 
            // cbo_tipo
            // 
            cbo_tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_tipo.FormattingEnabled = true;
            cbo_tipo.Items.AddRange(new object[] { "Matéria prima", "Serviço", "Produto acabado", "Consultoria" });
            cbo_tipo.Location = new Point(174, 316);
            cbo_tipo.Name = "cbo_tipo";
            cbo_tipo.Size = new Size(114, 23);
            cbo_tipo.TabIndex = 43;
            // 
            // chk_ativo
            // 
            chk_ativo.AutoSize = true;
            chk_ativo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            chk_ativo.Location = new Point(505, 24);
            chk_ativo.Name = "chk_ativo";
            chk_ativo.Size = new Size(60, 21);
            chk_ativo.TabIndex = 44;
            chk_ativo.Text = "Ativo";
            chk_ativo.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(25, 296);
            label8.Name = "label8";
            label8.Size = new Size(24, 17);
            label8.TabIndex = 48;
            label8.Text = "UF";
            // 
            // cbo_uf
            // 
            cbo_uf.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_uf.FormattingEnabled = true;
            cbo_uf.Items.AddRange(new object[] { "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO" });
            cbo_uf.Location = new Point(25, 316);
            cbo_uf.Name = "cbo_uf";
            cbo_uf.Size = new Size(62, 23);
            cbo_uf.TabIndex = 42;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(385, 239);
            label7.Name = "label7";
            label7.Size = new Size(50, 17);
            label7.TabIndex = 46;
            label7.Text = "Cidade";
            // 
            // txt_cidade
            // 
            txt_cidade.Location = new Point(387, 261);
            txt_cidade.Name = "txt_cidade";
            txt_cidade.Size = new Size(308, 23);
            txt_cidade.TabIndex = 41;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(23, 240);
            label6.Name = "label6";
            label6.Size = new Size(45, 17);
            label6.TabIndex = 44;
            label6.Text = "Bairro";
            // 
            // txt_bairro
            // 
            txt_bairro.Location = new Point(25, 261);
            txt_bairro.Name = "txt_bairro";
            txt_bairro.Size = new Size(308, 23);
            txt_bairro.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(23, 179);
            label5.Name = "label5";
            label5.Size = new Size(64, 17);
            label5.TabIndex = 42;
            label5.Text = "Endereço";
            // 
            // txt_endereco
            // 
            txt_endereco.Location = new Point(25, 201);
            txt_endereco.Name = "txt_endereco";
            txt_endereco.Size = new Size(375, 23);
            txt_endereco.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(446, 137);
            label4.Name = "label4";
            label4.Size = new Size(39, 17);
            label4.TabIndex = 40;
            label4.Text = "CNPJ";
            // 
            // mask_cpnj
            // 
            mask_cpnj.Location = new Point(491, 135);
            mask_cpnj.Mask = "99,999,999/9999-99";
            mask_cpnj.Name = "mask_cpnj";
            mask_cpnj.Size = new Size(122, 23);
            mask_cpnj.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(23, 113);
            label2.Name = "label2";
            label2.Size = new Size(138, 17);
            label2.TabIndex = 38;
            label2.Text = "Nome do Fornecedor";
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(25, 136);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(375, 23);
            txt_nome.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 24);
            label1.Name = "label1";
            label1.Size = new Size(145, 17);
            label1.TabIndex = 36;
            label1.Text = "Código do Fornecedor";
            // 
            // txt_id
            // 
            txt_id.Enabled = false;
            txt_id.Location = new Point(25, 50);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(100, 23);
            txt_id.TabIndex = 35;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cancelar.Location = new Point(421, 389);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(92, 36);
            btn_cancelar.TabIndex = 46;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_salvar
            // 
            btn_salvar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_salvar.Location = new Point(294, 389);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(92, 36);
            btn_salvar.TabIndex = 45;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // btn_fechar
            // 
            btn_fechar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_fechar.Location = new Point(796, 484);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(92, 36);
            btn_fechar.TabIndex = 5;
            btn_fechar.Text = "Fechar";
            btn_fechar.UseVisualStyleBackColor = true;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // FrmFornecedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 525);
            Controls.Add(tab_fornecedor);
            Controls.Add(btn_fechar);
            Name = "FrmFornecedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmFornecedores";
            Load += FrmFornecedores_Load;
            tab_fornecedor.ResumeLayout(false);
            tabDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabForm.ResumeLayout(false);
            tabForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tab_fornecedor;
        private TabPage tabDados;
        private Button btn_excluir;
        private Button btn_editar;
        private Button btn_novo;
        private TabPage tabForm;
        private Button btn_cancelar;
        private Button btn_salvar;
        private Button btn_fechar;
        private DataGridView dataGridView1;
        private Label label3;
        private ComboBox cbo_tipo;
        private CheckBox chk_ativo;
        private Label label8;
        private ComboBox cbo_uf;
        private Label label7;
        private TextBox txt_cidade;
        private Label label6;
        private TextBox txt_bairro;
        private Label label5;
        private TextBox txt_endereco;
        private Label label4;
        private MaskedTextBox mask_cpnj;
        private Label label2;
        private TextBox txt_nome;
        private Label label1;
        private TextBox txt_id;
    }
}