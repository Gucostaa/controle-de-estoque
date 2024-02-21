using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeEstoque
{
    public partial class FrmFornecedores : Form
    {
        public FrmFornecedores()
        {
            InitializeComponent();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            Botoes(2);
            tab_fornecedor.SelectedTab = tabForm;

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (txt_nome.TextLength < 5)
            {
                Uteis.msgAviso("O campo \"Nome do Fornecedor\" deve ter pelo menos 5 caráter");
                txt_nome.Focus();
                return;
            }

            if (cbo_uf.SelectedIndex == -1)
            {
                Uteis.msgAviso("O Campo \"UF\"deve ser selecionado");
                return;
            }
            if (cbo_tipo.SelectedIndex == -1)
            {
                Uteis.msgAviso("O Campo \"Tipo\"deve ser selecionado");
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

            int.TryParse(txt_id.Text, out int id);
            string nomeFornecedor = txt_nome.Text;
            string Cnpj = cnpjText;
            string endereco = txt_endereco.Text;
            string bairro = txt_endereco.Text;
            string cidade = txt_cidade.Text;
            var uf = cbo_uf.SelectedItem.ToString();
            var tipo = cbo_tipo.SelectedItem.ToString();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Botoes(1);
            tab_fornecedor.SelectedTab = tabDados;
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmFornecedores_Load(object sender, EventArgs e)
        {
            Botoes(1);
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

    }
}
