namespace ControleDeEstoque
{
    partial class FrmClientes
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
            tab_cliente = new TabControl();
            tabDados = new TabPage();
            dataGridView1 = new DataGridView();
            btn_excluir = new Button();
            btn_editar = new Button();
            btn_novo = new Button();
            tabForm = new TabPage();
            chk_ativo = new CheckBox();
            label8 = new Label();
            cmb_uf = new ComboBox();
            label7 = new Label();
            txt_cidade = new TextBox();
            label6 = new Label();
            txt_bairro = new TextBox();
            label5 = new Label();
            txt_endereco = new TextBox();
            label4 = new Label();
            mask_cpnj = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            txt_nome = new TextBox();
            label1 = new Label();
            txt_id = new TextBox();
            btn_cancelar = new Button();
            btn_salvar = new Button();
            btn_fechar = new Button();
            tab_cliente.SuspendLayout();
            tabDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabForm.SuspendLayout();
            SuspendLayout();
            // 
            // tab_cliente
            // 
            tab_cliente.Controls.Add(tabDados);
            tab_cliente.Controls.Add(tabForm);
            tab_cliente.Location = new Point(12, 12);
            tab_cliente.Name = "tab_cliente";
            tab_cliente.SelectedIndex = 0;
            tab_cliente.Size = new Size(1149, 471);
            tab_cliente.TabIndex = 2;
            // 
            // tabDados
            // 
            tabDados.Controls.Add(dataGridView1);
            tabDados.Controls.Add(btn_fechar);
            tabDados.Controls.Add(btn_excluir);
            tabDados.Controls.Add(btn_editar);
            tabDados.Controls.Add(btn_novo);
            tabDados.Location = new Point(4, 24);
            tabDados.Name = "tabDados";
            tabDados.Padding = new Padding(3);
            tabDados.Size = new Size(1141, 443);
            tabDados.TabIndex = 0;
            tabDados.Text = "Dados";
            tabDados.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-19, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1164, 399);
            dataGridView1.TabIndex = 5;
            // 
            // btn_excluir
            // 
            btn_excluir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_excluir.Location = new Point(657, 403);
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
            btn_editar.Location = new Point(532, 403);
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
            btn_novo.Location = new Point(405, 403);
            btn_novo.Name = "btn_novo";
            btn_novo.Size = new Size(92, 36);
            btn_novo.TabIndex = 2;
            btn_novo.Text = "Novo";
            btn_novo.UseVisualStyleBackColor = true;
            btn_novo.Click += btn_novo_Click;
            // 
            // tabForm
            // 
            tabForm.Controls.Add(chk_ativo);
            tabForm.Controls.Add(label8);
            tabForm.Controls.Add(cmb_uf);
            tabForm.Controls.Add(label7);
            tabForm.Controls.Add(txt_cidade);
            tabForm.Controls.Add(label6);
            tabForm.Controls.Add(txt_bairro);
            tabForm.Controls.Add(label5);
            tabForm.Controls.Add(txt_endereco);
            tabForm.Controls.Add(label4);
            tabForm.Controls.Add(mask_cpnj);
            tabForm.Controls.Add(label3);
            tabForm.Controls.Add(label2);
            tabForm.Controls.Add(txt_nome);
            tabForm.Controls.Add(label1);
            tabForm.Controls.Add(txt_id);
            tabForm.Controls.Add(btn_cancelar);
            tabForm.Controls.Add(btn_salvar);
            tabForm.Location = new Point(4, 24);
            tabForm.Name = "tabForm";
            tabForm.Padding = new Padding(3);
            tabForm.Size = new Size(1141, 443);
            tabForm.TabIndex = 1;
            tabForm.Text = "Cadastro";
            tabForm.UseVisualStyleBackColor = true;
            // 
            // chk_ativo
            // 
            chk_ativo.AutoSize = true;
            chk_ativo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            chk_ativo.Location = new Point(500, 27);
            chk_ativo.Name = "chk_ativo";
            chk_ativo.Size = new Size(60, 21);
            chk_ativo.TabIndex = 26;
            chk_ativo.Text = "Ativo";
            chk_ativo.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(20, 299);
            label8.Name = "label8";
            label8.Size = new Size(24, 17);
            label8.TabIndex = 33;
            label8.Text = "UF";
            // 
            // cmb_uf
            // 
            cmb_uf.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_uf.FormattingEnabled = true;
            cmb_uf.Items.AddRange(new object[] { "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO" });
            cmb_uf.Location = new Point(20, 319);
            cmb_uf.Name = "cmb_uf";
            cmb_uf.Size = new Size(62, 23);
            cmb_uf.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(380, 242);
            label7.Name = "label7";
            label7.Size = new Size(50, 17);
            label7.TabIndex = 31;
            label7.Text = "Cidade";
            // 
            // txt_cidade
            // 
            txt_cidade.Location = new Point(382, 264);
            txt_cidade.Name = "txt_cidade";
            txt_cidade.Size = new Size(308, 23);
            txt_cidade.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(18, 243);
            label6.Name = "label6";
            label6.Size = new Size(45, 17);
            label6.TabIndex = 29;
            label6.Text = "Bairro";
            // 
            // txt_bairro
            // 
            txt_bairro.Location = new Point(20, 264);
            txt_bairro.Name = "txt_bairro";
            txt_bairro.Size = new Size(308, 23);
            txt_bairro.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(18, 182);
            label5.Name = "label5";
            label5.Size = new Size(64, 17);
            label5.TabIndex = 27;
            label5.Text = "Endereço";
            // 
            // txt_endereco
            // 
            txt_endereco.Location = new Point(20, 204);
            txt_endereco.Name = "txt_endereco";
            txt_endereco.Size = new Size(375, 23);
            txt_endereco.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(441, 140);
            label4.Name = "label4";
            label4.Size = new Size(39, 17);
            label4.TabIndex = 25;
            label4.Text = "CNPJ";
            // 
            // mask_cpnj
            // 
            mask_cpnj.Location = new Point(486, 138);
            mask_cpnj.Mask = "99,999,999/9999-99";
            mask_cpnj.Name = "mask_cpnj";
            mask_cpnj.Size = new Size(122, 23);
            mask_cpnj.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(18, 180);
            label3.Name = "label3";
            label3.Size = new Size(0, 17);
            label3.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(18, 116);
            label2.Name = "label2";
            label2.Size = new Size(112, 17);
            label2.TabIndex = 21;
            label2.Text = "Nome do Cliente";
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(20, 139);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(375, 23);
            txt_nome.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(18, 27);
            label1.Name = "label1";
            label1.Size = new Size(119, 17);
            label1.TabIndex = 19;
            label1.Text = "Código do Cliente";
            // 
            // txt_id
            // 
            txt_id.Enabled = false;
            txt_id.Location = new Point(20, 53);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(100, 23);
            txt_id.TabIndex = 18;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cancelar.Location = new Point(529, 391);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(92, 36);
            btn_cancelar.TabIndex = 28;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_salvar
            // 
            btn_salvar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_salvar.Location = new Point(402, 391);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(92, 36);
            btn_salvar.TabIndex = 27;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // btn_fechar
            // 
            btn_fechar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_fechar.Location = new Point(769, 403);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(92, 36);
            btn_fechar.TabIndex = 3;
            btn_fechar.Text = "Fechar";
            btn_fechar.UseVisualStyleBackColor = true;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 523);
            Controls.Add(tab_cliente);
            Name = "FrmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmClientes";
            Load += FrmClientes_Load;
            tab_cliente.ResumeLayout(false);
            tabDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabForm.ResumeLayout(false);
            tabForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tab_cliente;
        private TabPage tabDados;
        private DataGridView dataGridView1;
        private Button btn_excluir;
        private Button btn_editar;
        private Button btn_novo;
        private TabPage tabForm;
        private Button btn_cancelar;
        private Button btn_salvar;
        private Button btn_fechar;
        private Label label2;
        private TextBox txt_nome;
        private Label label1;
        private TextBox txt_id;
        private Label label3;
        private MaskedTextBox mask_cpnj;
        private Label label4;
        private Label label6;
        private TextBox txt_bairro;
        private Label label5;
        private TextBox txt_endereco;
        private Label label7;
        private TextBox txt_cidade;
        private ComboBox cmb_uf;
        private Label label8;
        private CheckBox chk_ativo;
    }
}