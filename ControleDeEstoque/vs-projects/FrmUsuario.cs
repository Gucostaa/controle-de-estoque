using ControleDeEstoque.Repositorio;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeEstoque.Views
{
    public partial class FrmUsuario : Form
    {
        Usuario Usuario = new Usuario();

        //variavel de controle de edição ou inclusão
        private string acao = string.Empty;
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            acao = "novo";
            Botoes(2);
            tab_usuario.SelectedTab = tabForm;
            txt_user.Focus();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            acao = "editar";
            Botoes(2);
            tab_usuario.SelectedTab = tabForm;

            var idUsuario = dataGridView1.CurrentRow.Cells["idUsuario"].Value;

            //Chamar o método GetCliente
            if (idUsuario != null)
            {
                Usuario.GetUsuario(Convert.ToInt32(idUsuario));
                txt_id.Text = Usuario.idUsuario.ToString();
                txt_senha.Text = Usuario.senha.ToString();
                txt_user.Text = Usuario.user.ToString();
                cbo_nivel.SelectedItem = Usuario.nivel;  
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            var idUsuario = dataGridView1.CurrentRow.Cells["idUsuario"].Value;
            string? usuario = dataGridView1.CurrentRow.Cells["user"].Value.ToString();

            if (Uteis.msgConfirmacao("Deseja apagar " + usuario + "?") == DialogResult.OK)
            {
                try
                {
                    Usuario.ExcluirUsuario(Convert.ToInt32(idUsuario));
                    Uteis.msgInformacao("Registro deletado com Sucesso!");
                    LoadGrid();
                }
                catch (Exception ex)
                {
                    Uteis.msgErro("Não foi possível apagar " + ex.Message);
                }
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {

            bool verifica = VerificaSenha();

            if (txt_user.TextLength < 5)
            {
                Uteis.msgAviso("O campo \" Usuário \" deve ter pelo menos 5 caráter");
                txt_user.Focus();
                return;
            }

            if (cbo_nivel.SelectedIndex == -1)
            {
                Uteis.msgAviso("O Campo \"Nível\"deve ser selecionado");
                return;
            }
            if (txt_senha.Text == "")
            {
                Uteis.msgAviso("O Campo \"Senha\"deve ser preenchido");
                return;
            }

            if (txt_confirmarSenha.Text == "")
            {
                Uteis.msgAviso("O Campo \"Confirmar Senha\"deve ser preenchido");
                return;
            }

            if (verifica == true)
            {              

                if (acao == "editar")
                {
                    Usuario.idUsuario = Convert.ToInt32(txt_id.Text);
                }

                Usuario.user = txt_user.Text;
                Usuario.senha = txt_senha.Text;
                Usuario.nivel = cbo_nivel.SelectedItem.ToString();


                try
                {
                    Usuario.SalvarUsuario(acao);
                    LoadGrid();
                    Uteis.msgInformacao("Registro Gravado com Sucesso!!");
                    Botoes(1);
                    tab_usuario.SelectedTab = tabDados;
                }
                catch (Exception ex)
                {
                    Uteis.msgErro("Houve um problema, erro: " + ex.Message);
                }
            }
            else
            {
                Uteis.msgAviso("Senhas diferentes");
            }


        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Botoes(1);
            tab_usuario.SelectedTab = tabDados;
        }

        private void Botoes(int tab)
        {
            if (tab == 1)
            {
                btn_novo.Enabled = true;
                btn_editar.Enabled = true;
                btn_excluir.Enabled = true;
                btn_salvar.Enabled = false;
                btn_cancelar.Enabled = false;
                btn_fechar.Enabled = true;

                txt_user.Text = string.Empty;
                txt_senha.Text = string.Empty;
                cbo_nivel.SelectedIndex = -1;
                txt_id.Text = string.Empty;
            }
            if (tab == 2)
            {
                btn_novo.Enabled = false;
                btn_editar.Enabled = false;
                btn_excluir.Enabled = false;
                btn_salvar.Enabled = true;
                btn_cancelar.Enabled = true;
                btn_fechar.Enabled = false;
                txt_id.Text = string.Empty;
            }
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            Botoes(1);
            LoadGrid();
        }

        public void LoadGrid()
        {
            DataTable dataTable = Usuario.GetUsuarios();
            dataGridView1.DataSource = dataTable;
            PersonalizarGrid();
        }

        public bool VerificaSenha()
        {
            string  senhaConf = txt_confirmarSenha.Text;
            string senha = txt_senha.Text;

            if(senha == senhaConf)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PersonalizarGrid()
        {
            dataGridView1.Columns["idUsuario"].HeaderText = "Código";
            dataGridView1.Columns["idUsuario"].Width = 70;
            dataGridView1.Columns["idUsuario"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns["user"].HeaderText = "Usuário";
            dataGridView1.Columns["user"].Width = 450;
            dataGridView1.Columns["user"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dataGridView1.Columns["nivel"].HeaderText = "Nível";
            dataGridView1.Columns["nivel"].Width = 290;
            dataGridView1.Columns["nivel"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
    }
}
