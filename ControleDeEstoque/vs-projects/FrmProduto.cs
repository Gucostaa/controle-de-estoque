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
    public partial class FrmProduto : Form
    {
        Produto produto = new Produto();

        //variavel de controle de edição ou inclusão
        private string acao = string.Empty;

        public FrmProduto()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            acao = "novo";
            Botoes(2);
            tab_controle.SelectedTab = tabForm;
            txt_NomeProduto.Focus();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            acao = "editar";
            Botoes(2);
            tab_controle.SelectedTab = tabForm;

            var idProduto = dataGridView1.CurrentRow.Cells["idProduto"].Value;

            //Chamar o método GetProduto
            if(idProduto != null)
            {
                produto.GetProduto(Convert.ToInt32(idProduto));
                txt_id.Text = produto.IdProduto.ToString();
                txt_NomeProduto.Text = produto.NomeProduto.ToString();
                cbo_unidade.SelectedItem = produto.Unidade.ToString();
                txt_preco.Text = produto.Preco.ToString("N2");
                txt_imposto.Text = produto.Imposto.ToString("N2");
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            var idProduto = dataGridView1.CurrentRow.Cells["idProduto"].Value;
            string? nome = dataGridView1.CurrentRow.Cells["nomeProduto"].Value.ToString();

            if(Uteis.msgConfirmacao("Deseja apagar " + nome + "?") == DialogResult.OK)
            {
                try
                {
                    produto.ExcluirProduto(Convert.ToInt32(idProduto));
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
            if(txt_NomeProduto.TextLength < 5)
             {
                Uteis.msgAviso("O campo \"Nome do Produto\" deve ter pelo menos 5 caráter");
                txt_NomeProduto.Focus();
                 return;
             }
            
            if(cbo_unidade.SelectedIndex == -1)
            {
                Uteis.msgAviso("O Campo \"Unidade\"deve ser selecionado");
                return;
            }
            if(txt_preco.Text == "")
            {
                Uteis.msgAviso("O Campo \"Preço\"deve ser preenchido"); 
                return;
            }
            if (txt_imposto.Text == "")
            {
                Uteis.msgAviso("O Campo \"Imposto\"deve ser preenchido");
                return;
            }

            if(acao == "editar")
            {
                produto.IdProduto = Convert.ToInt32(txt_id.Text);
            }

            produto.NomeProduto = txt_NomeProduto.Text;
            produto.Unidade = cbo_unidade.SelectedItem.ToString();
            produto.Preco = Convert.ToDouble(txt_preco.Text);
            produto.Imposto = Convert.ToDouble(txt_imposto.Text);

            try
            {
                produto.SalvarProduto(acao);
                LoadGrid();
                Uteis.msgInformacao("Registro Gravado com Sucesso!!");
                Botoes(1);
                tab_controle.SelectedTab = tabDados;
            }
            catch (Exception ex)
            {
                Uteis.msgErro("Houve um problema, erro: " + ex.Message);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Botoes(1);
            tab_controle.SelectedTab = tabDados;
        }

        //Metodo para controle dos botões
        private void Botoes(int tab)
        {
            if (tab == 1)
            {
                btn_novo.Enabled= true;
                btn_editar.Enabled= true;
                btn_excluir.Enabled= true;
                btn_salvar.Enabled= false;
                btn_cancelar.Enabled= false;
                btn_fechar.Enabled= true;

                txt_NomeProduto.Text = string.Empty;
                txt_preco.Text = string.Empty;
                txt_imposto.Text = string.Empty;
                cbo_unidade.SelectedIndex = -1;
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

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            Botoes(1);
            LoadGrid();
        }

        private void txt_preco_KeyPress(object sender, KeyPressEventArgs e)
        {
            Uteis.ValidarEntradaNumerica(e);
        }

        private void txt_imposto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Uteis.ValidarEntradaNumerica(e);
        }

        public void LoadGrid()
        {
            DataTable dataTable = Produto.GetProdutos();
            dataGridView1.DataSource = dataTable;
            PersonalizarGrid();
        }


        public void PersonalizarGrid()
        {
            dataGridView1.Columns["idProduto"].HeaderText = "Código";
            dataGridView1.Columns["idProduto"].Width = 70;
            dataGridView1.Columns["idProduto"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns["nomeProduto"].HeaderText = "Nome do Produto";
            dataGridView1.Columns["nomeProduto"].Width = 350;
            dataGridView1.Columns["nomeProduto"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dataGridView1.Columns["unidade"].HeaderText = "Unidade";
            dataGridView1.Columns["unidade"].Width = 100;
            dataGridView1.Columns["unidade"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dataGridView1.Columns["preco"].HeaderText = "Preço";
            dataGridView1.Columns["preco"].Width = 100;
            dataGridView1.Columns["preco"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["preco"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["imposto"].DefaultCellStyle.Format = "N2";

            dataGridView1.Columns["imposto"].HeaderText = "% Imposto";
            dataGridView1.Columns["imposto"].Width = 100;
            dataGridView1.Columns["imposto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["imposto"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["imposto"].DefaultCellStyle.Format = "N2";

        }

    }
}
