using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleDeEstoque.Repositorio;

namespace ControleDeEstoque
{
    public partial class FrmClientes : Form
    {
        Cliente cliente = new Cliente();


        //variavel de controle de edição ou inclusão
        private string acao = string.Empty;

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            acao = "novo";
            chk_ativo.Checked = true;
            Botoes(2);
            tab_cliente.SelectedTab = tabForm;
            txt_bairro.Focus();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            acao = "editar";
            Botoes(2);
            tab_cliente.SelectedTab = tabForm;

            var idCliente = dataGridView1.CurrentRow.Cells["idCliente"].Value;

            //Chamar o método GetCliente
            if (idCliente != null)
            {
                cliente.GetCliente(Convert.ToInt32(idCliente));
                txt_id.Text = cliente.idCliente.ToString();
                txt_nome.Text = cliente.nomeCliente.ToString();
                txt_endereco.Text = cliente.endereco.ToString();
                txt_bairro.Text = cliente.bairro.ToString();
                cmb_uf.SelectedItem = cliente.uf;
                mask_cpnj.Text = cliente.cnpj.ToString();
                txt_cidade.Text = cliente.cidade.ToString();
                chk_ativo.Checked = Convert.ToBoolean(cliente.ativo);
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            var idCliente = dataGridView1.CurrentRow.Cells["idCliente"].Value;
            string? nome = dataGridView1.CurrentRow.Cells["nomeCliente"].Value.ToString();

            if (Uteis.msgConfirmacao("Deseja apagar " + nome + "?") == DialogResult.OK)
            {
                try
                {
                    cliente.ExcluirCliente(Convert.ToInt32(idCliente));
                    Uteis.msgInformacao("Registro deletado com Sucesso!");
                    LoadGrid();
                }
                catch (Exception ex)
                {
                    Uteis.msgErro("Não foi possível apagar " + ex.Message);
                }
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (txt_nome.TextLength < 5)
            {
                Uteis.msgAviso("O campo \"Nome do Cliente\" deve ter pelo menos 5 caráter");
                txt_nome.Focus();
                return;
            }

            if (cmb_uf.SelectedIndex == -1)
            {
                Uteis.msgAviso("O Campo \"UF\"deve ser selecionado");
                return;
            }
            
            if (txt_endereco.Text == "")
            {
                Uteis.msgAviso("O Campo \"Endereço\"deve ser preenchido");
                return;
            }
            if (txt_bairro.Text == "")
            {
                Uteis.msgAviso("O Campo \"Bairro\"deve ser preenchido");
                return;
            }
            if (txt_cidade.Text == "")
            {
                Uteis.msgAviso("O Campo \"Cidade\"deve ser preenchido");
                return;
            }
            string cnpjText = mask_cpnj.Text;
            if (cnpjText.Length != 18)
            {
                Uteis.msgAviso("O \"CNPJ\" deve conter 14 dígitos");
                return;
            }

            if (acao == "editar")
            {
                cliente.idCliente = Convert.ToInt32(txt_id.Text);
            }

            cliente.nomeCliente= txt_nome.Text;
            cliente.endereco= txt_endereco.Text;
            cliente.cnpj= cnpjText;
            cliente.bairro= txt_bairro.Text;
            cliente.cidade= txt_cidade.Text;
            cliente.uf= cmb_uf.Text;
            cliente.ativo= chk_ativo.Checked;   

            try
            {
                cliente.SalvarCliente(acao);
                LoadGrid();
                Uteis.msgInformacao("Registro Gravado com Sucesso!!");
                Botoes(1);
                tab_cliente.SelectedTab = tabDados;
            }
            catch (Exception ex)
            {
                Uteis.msgErro("Houve um problema, erro: " + ex.Message);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Botoes(1);
            tab_cliente.SelectedTab = tabDados;
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadGrid()
        {
            DataTable dataTable = Cliente.GetClientes();
            dataGridView1.DataSource = dataTable;
            PersonalizarGrid();
        }

        public void PersonalizarGrid()
        {
            dataGridView1.Columns["idCliente"].HeaderText = "Código";
            dataGridView1.Columns["idCliente"].Width = 70;
            dataGridView1.Columns["idCliente"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns["nomeCliente"].HeaderText = "Nome do Cliente";
            dataGridView1.Columns["nomeCliente"].Width = 300;
            dataGridView1.Columns["nomeCliente"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dataGridView1.Columns["endereco"].HeaderText = "Endereço";
            dataGridView1.Columns["endereco"].Width = 350;
            dataGridView1.Columns["endereco"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dataGridView1.Columns["cidade"].HeaderText = "Cidade";
            dataGridView1.Columns["cidade"].Width = 200;
            dataGridView1.Columns["cidade"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
 

            dataGridView1.Columns["uf"].HeaderText = "UF";
            dataGridView1.Columns["uf"].Width = 50;
            dataGridView1.Columns["uf"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns["ativo"].HeaderText = "Ativo";
            dataGridView1.Columns["ativo"].Width = 60;
            dataGridView1.Columns["ativo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dataGridView1.Columns["cnpj"].HeaderText = "Cnpj";
            dataGridView1.Columns["cnpj"].Width = 150;
            //dataGridView1.Columns["cnpj"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["cnpj"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns["bairro"].HeaderText = "Bairro";
            dataGridView1.Columns["bairro"].Width = 100;
            //dataGridView1.Columns["imposto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["bairro"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
        //Metodo para controle dos botões
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
            }
            if (tab == 2)
            {
                btn_novo.Enabled = false;
                btn_editar.Enabled = false;
                btn_excluir.Enabled = false;
                btn_salvar.Enabled = true;
                btn_cancelar.Enabled = true;
                btn_fechar.Enabled = false;
            }
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            Botoes(1);
            LoadGrid();
        }
    }
}
