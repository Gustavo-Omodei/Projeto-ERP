using System;
using System.Linq;
using System.Windows.Forms;

namespace MiniERP
{
    public partial class FormProdutos : Form
    {
        public FormProdutos()
        {
            InitializeComponent();
        }

        private void button_Salvar_Click(object sender, EventArgs e)
        {
            cadastroProduto();
        }

        private void cadastroProduto()
        {
            using (var contexto = new erpContext())
            {
                Produto p = new Produto();
                p.TipoProduto = textBox_TipoProduto.Text;

                if (string.IsNullOrWhiteSpace(p.TipoProduto))
                {
                    MessageBox.Show("Produto inválido");
                    return;
                }
                else
                {
                    if (!int.TryParse(textBox_TipoProduto.Text, out int produto))
                    {
                        p.TipoProduto = textBox_TipoProduto.Text;
                    }
                    else
                    {
                        MessageBox.Show("Produto inválido");
                        return;
                    }
                }

                if (decimal.TryParse(textBox_Valor.Text, out decimal valor))
                {
                    p.Valor = valor;
                }
                else
                {
                    MessageBox.Show("Valor inválido!");
                    return;
                }

                if (int.TryParse(textBox_IdFornecedor.Text, out int idFornecedor))
                {
                    p.IdFornecedor = idFornecedor;

                    Fornecedore fornecedor = contexto.Fornecedores.Find(idFornecedor);

                    if (fornecedor != null)
                    {
                        contexto.Produtos.Add(p);
                        contexto.SaveChanges();
                        MessageBox.Show("Cadastro feito com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Fornecedor inválido!");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("ID do fornecedor inválido!");
                    return;
                }

            }

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientes form1 = new FormClientes();
            form1.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaClientes consulta = new ConsultaClientes();
            consulta.ShowDialog();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormFornecedor form2 = new FormFornecedor();
            form2.ShowDialog();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaFornecedor consulta = new ConsultaFornecedor();
            consulta.ShowDialog();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormProdutos form3 = new FormProdutos();
            form3.ShowDialog();
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ConsultaProdutos consulta = new ConsultaProdutos();
            consulta.ShowDialog();
        }

        private void cadastrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormNotaFiscal form4 = new FormNotaFiscal();
            form4.ShowDialog();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desenvolvido por Gustavo Omodei");
        }
    }
}