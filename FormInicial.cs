namespace MiniERP
{
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FormClientes form1 = new FormClientes();
            form1.ShowDialog();

        }

        private void button_Fornecedor_Click(object sender, EventArgs e)
        {
            FormFornecedor form2 = new FormFornecedor();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormProdutos form3 = new FormProdutos();
            form3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormNotaFiscal form4 = new FormNotaFiscal();
            form4.ShowDialog();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientes form1 = new FormClientes();
            form1.ShowDialog();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormFornecedor form2 = new FormFornecedor();
            form2.ShowDialog();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormProdutos form3 = new FormProdutos();
            form3.ShowDialog();
        }

        private void cadastrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormNotaFiscal form4 = new FormNotaFiscal();
            form4.ShowDialog();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("© Software desenvolvido por Gustavo Omodei");
        }

        private void cadastrarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormClientes form1 = new FormClientes();
            form1.ShowDialog();
        }

        private void cadastrarToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            FormFornecedor form2 = new FormFornecedor();
            form2.ShowDialog();
        }

        private void cadastrarToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            FormProdutos form3 = new FormProdutos();
            form3.ShowDialog();
        }

        private void cadastrarToolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            FormNotaFiscal form4 = new FormNotaFiscal();
            form4.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaClientes consulta = new ConsultaClientes();
            consulta.ShowDialog();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaFornecedor consulta = new ConsultaFornecedor();
            consulta.ShowDialog();
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ConsultaProdutos consulta = new ConsultaProdutos();
            consulta.ShowDialog();
        }

        private void sobreToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Desenvolvido por Gustavo Omodei");
        }
    }
}