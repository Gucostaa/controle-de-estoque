using System.Data;


namespace ControleDeEstoque
{
    public partial class FrmCidade : Form
    {
        public FrmCidade()
        {
            InitializeComponent();
        }

        private void FrmCidade_Load(object sender, EventArgs e)
        {

            LoadGrid("","","","");
        }

        public void LoadGrid(string Busca,string populacaoDe,string populacaoAte,string uf)
        {
            DataTable dt = Cidade.GetCidades(Busca,populacaoDe,populacaoAte,uf);

            dataGridView1.DataSource = dt;
        }

        private void text_buscado_TextChanged(object sender, EventArgs e)
        {
            LoadGrid(text_buscado.Text,"","","");
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            LoadGrid("",txt_populacaoDe.Text,txt_populacaoAte.Text,cbo_Uf.SelectedItem.ToString());
        }
    }
}
