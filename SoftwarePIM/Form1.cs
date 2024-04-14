namespace SoftwarePIM
{
    public partial class Frm_TelaInicial : Form
    {
        public Frm_TelaInicial()
        {
            InitializeComponent();
        }

        private void btn_Mapa_Click(object sender, EventArgs e)
        {
            // Criando uma instância da Tela do Mapa
            Frm_TelaMapa frm_TelaMapa = new Frm_TelaMapa();

            // Exibindo o FormSecundario
            frm_TelaMapa.Show();
        }

        private void btn_Historia_Click(object sender, EventArgs e)
        {
            // Criando uma instância do FormSecundario
            Frm_TelaHistoria frm_TelaHistoria = new Frm_TelaHistoria();

            // Exibindo o FormSecundario
            frm_TelaHistoria.Show();  
        }

        private void btn_Avaliacao_Click(object sender, EventArgs e)
        {
            // Criando uma instância do FormSecundario
            Frm_TelaAvaliacao frm_TelaAvaliacao = new Frm_TelaAvaliacao();

            // Exibindo o FormSecundario
            frm_TelaAvaliacao.Show();
        }
    }
}
