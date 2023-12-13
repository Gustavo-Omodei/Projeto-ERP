using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniERP
{
    public partial class FormFornecedor : Form
    {
        public FormFornecedor()
        {
            InitializeComponent();
        }

        private void cadastrarFornecedor()
        {
            using (var contexto = new erpContext())
            {

                Fornecedore f = new Fornecedore();
                f.Nome = textBox_Nome.Text;
                f.RazaoSocial = textBox_Razao.Text;
                f.Email = textBox_Email.Text;
                f.CNPJ = textBox_CNPJ.Text;
                f.Telefone = textBox_Telefone.Text;
                f.Endereco = textBox_Endereco.Text;


                if (string.IsNullOrWhiteSpace(f.Nome))
                {
                    MessageBox.Show("Nome inválido");
                    return;
                }
                else
                {
                    if (!int.TryParse(textBox_Nome.Text, out int nome))
                    {
                        f.Nome = textBox_Nome.Text;
                    }
                    else
                    {
                        MessageBox.Show("Nome inválido");
                        return;
                    }
                }

                if (string.IsNullOrWhiteSpace(f.RazaoSocial))
                {
                    MessageBox.Show("Razão social inválida");
                    return;
                }
                else
                {
                    if (!int.TryParse(textBox_Razao.Text, out int razao))
                    {
                        f.RazaoSocial = textBox_Razao.Text;
                    }
                    else
                    {
                        MessageBox.Show("Razão Social inválida");
                    }

                }

                if (string.IsNullOrWhiteSpace(f.Email))
                {
                    MessageBox.Show("Email inválido");
                    return;
                }
                else
                {
                    if (!int.TryParse(textBox_Email.Text, out int email))
                    {
                        f.Email = textBox_Email.Text;
                    }
                    else
                    {
                        MessageBox.Show("Email inválido");
                        return;
                    }

                }
                if (string.IsNullOrWhiteSpace(f.Endereco))
                {
                    MessageBox.Show("Endereço inválido");
                    return;
                }
                else
                {
                    if (!int.TryParse(textBox_Endereco.Text, out int endereco))
                    {
                        f.Endereco = textBox_Endereco.Text;
                    }
                    else
                    {
                        MessageBox.Show("Endereço inválido");
                        return;
                    }
                }

                if (long.TryParse(textBox_Telefone.Text, out long telefone))
                {
                    f.Telefone = telefone.ToString();
                }
                else
                {
                    MessageBox.Show("Número de telefone inválido!");
                    return;
                }

                if (long.TryParse(textBox_CNPJ.Text, out long cnpj))
                {
                    f.CNPJ = cnpj.ToString();
                }
                else
                {
                    MessageBox.Show("CNPJ inválido!");
                    return;
                }

                contexto.Add(f);
                contexto.SaveChanges();
                MessageBox.Show("Cadastro feito com sucesso!");
            }
        }

        private void button_Salvar_Fornecedor_Click(object sender, EventArgs e)
        {

            cadastrarFornecedor();
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
