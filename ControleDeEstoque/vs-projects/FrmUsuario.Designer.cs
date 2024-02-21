namespace ControleDeEstoque.Views
{
    partial class FrmUsuario
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
            btn_fechar = new Button();
            dataGridView1 = new DataGridView();
            tabForm = new TabPage();
            cbo_nivel = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            txt_senha = new TextBox();
            label2 = new Label();
            txt_user = new TextBox();
            label1 = new Label();
            txt_id = new TextBox();
            btn_cancelar = new Button();
            btn_salvar = new Button();
            tab_usuario = new TabControl();
            tabDados = new TabPage();
            btn_excluir = new Button();
            btn_editar = new Button();
            btn_novo = new Button();
            label5 = new Label();
            txt_confirmarSenha = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabForm.SuspendLayout();
            tab_usuario.SuspendLayout();
            tabDados.SuspendLayout();
            SuspendLayout();
            // 
            // btn_fechar
            // 
            btn_fechar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_fechar.Location = new Point(496, 402);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(92, 36);
            btn_fechar.TabIndex = 5;
            btn_fechar.Text = "Fechar";
            btn_fechar.UseVisualStyleBackColor = true;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(854, 399);
            dataGridView1.TabIndex = 5;
            // 
            // tabForm
            // 
            tabForm.Controls.Add(label5);
            tabForm.Controls.Add(txt_confirmarSenha);
            tabForm.Controls.Add(cbo_nivel);
            tabForm.Controls.Add(label4);
            tabForm.Controls.Add(label3);
            tabForm.Controls.Add(txt_senha);
            tabForm.Controls.Add(label2);
            tabForm.Controls.Add(txt_user);
            tabForm.Controls.Add(label1);
            tabForm.Controls.Add(txt_id);
            tabForm.Controls.Add(btn_cancelar);
            tabForm.Controls.Add(btn_salvar);
            tabForm.Location = new Point(4, 24);
            tabForm.Name = "tabForm";
            tabForm.Padding = new Padding(3);
            tabForm.Size = new Size(854, 447);
            tabForm.TabIndex = 1;
            tabForm.Text = "Cadastro";
            tabForm.UseVisualStyleBackColor = true;
            // 
            // cbo_nivel
            // 
            cbo_nivel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_nivel.FormattingEnabled = true;
            cbo_nivel.Items.AddRange(new object[] { "Estágiario", "Gerente", "Patrão" });
            cbo_nivel.Location = new Point(271, 217);
            cbo_nivel.Name = "cbo_nivel";
            cbo_nivel.Size = new Size(173, 23);
            cbo_nivel.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(298, 197);
            label4.Name = "label4";
            label4.Size = new Size(40, 17);
            label4.TabIndex = 32;
            label4.Text = "Nível";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 197);
            label3.Name = "label3";
            label3.Size = new Size(116, 17);
            label3.TabIndex = 30;
            label3.Text = "Senha do Usuário";
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(21, 217);
            txt_senha.Name = "txt_senha";
            txt_senha.PasswordChar = '*';
            txt_senha.Size = new Size(211, 23);
            txt_senha.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(21, 119);
            label2.Name = "label2";
            label2.Size = new Size(96, 17);
            label2.TabIndex = 21;
            label2.Text = "Nome Usuário";
            // 
            // txt_user
            // 
            txt_user.Location = new Point(20, 139);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(212, 23);
            txt_user.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 30);
            label1.Name = "label1";
            label1.Size = new Size(123, 17);
            label1.TabIndex = 19;
            label1.Text = "Código do Usuário";
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
            btn_cancelar.Location = new Point(398, 379);
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
            btn_salvar.Location = new Point(271, 379);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(92, 36);
            btn_salvar.TabIndex = 27;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // tab_usuario
            // 
            tab_usuario.Controls.Add(tabDados);
            tab_usuario.Controls.Add(tabForm);
            tab_usuario.Location = new Point(12, 28);
            tab_usuario.Name = "tab_usuario";
            tab_usuario.SelectedIndex = 0;
            tab_usuario.Size = new Size(862, 475);
            tab_usuario.TabIndex = 4;
            // 
            // tabDados
            // 
            tabDados.Controls.Add(btn_fechar);
            tabDados.Controls.Add(dataGridView1);
            tabDados.Controls.Add(btn_excluir);
            tabDados.Controls.Add(btn_editar);
            tabDados.Controls.Add(btn_novo);
            tabDados.Location = new Point(4, 24);
            tabDados.Name = "tabDados";
            tabDados.Padding = new Padding(3);
            tabDados.Size = new Size(854, 447);
            tabDados.TabIndex = 0;
            tabDados.Text = "Dados";
            tabDados.UseVisualStyleBackColor = true;
            // 
            // btn_excluir
            // 
            btn_excluir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_excluir.Location = new Point(380, 402);
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
            btn_editar.Location = new Point(255, 402);
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
            btn_novo.Location = new Point(128, 402);
            btn_novo.Name = "btn_novo";
            btn_novo.Size = new Size(92, 36);
            btn_novo.TabIndex = 2;
            btn_novo.Text = "Novo";
            btn_novo.UseVisualStyleBackColor = true;
            btn_novo.Click += btn_novo_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(23, 257);
            label5.Name = "label5";
            label5.Size = new Size(121, 17);
            label5.TabIndex = 35;
            label5.Text = "Confirmar a senha";
            // 
            // txt_confirmarSenha
            // 
            txt_confirmarSenha.Location = new Point(22, 277);
            txt_confirmarSenha.Name = "txt_confirmarSenha";
            txt_confirmarSenha.PasswordChar = '*';
            txt_confirmarSenha.Size = new Size(211, 23);
            txt_confirmarSenha.TabIndex = 34;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 503);
            Controls.Add(tab_usuario);
            Name = "FrmUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuários";
            Load += FrmUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabForm.ResumeLayout(false);
            tabForm.PerformLayout();
            tab_usuario.ResumeLayout(false);
            tabDados.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_fechar;
        private DataGridView dataGridView1;
        private TabPage tabForm;
        private Label label2;
        private TextBox txt_user;
        private Label label1;
        private TextBox txt_id;
        private Button btn_cancelar;
        private Button btn_salvar;
        private TabControl tab_usuario;
        private TabPage tabDados;
        private Button btn_excluir;
        private Button btn_editar;
        private Button btn_novo;
        private Label label4;
        private Label label3;
        private TextBox txt_senha;
        private ComboBox cbo_nivel;
        private Label label5;
        private TextBox txt_confirmarSenha;
    }
}