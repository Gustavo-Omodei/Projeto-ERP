using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniERP
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void cadastrarClientes()
        {

            using (var contexto = new erpContext())
            {

                Cliente c = new Cliente();
                NotaFiscal n = new NotaFiscal();
                c.Nome = textBox_Nome.Text;
                c.Email = textBox_Email.Text;
                c.Telefone = textBox_Telefone.Text;
                c.Cpf = textBox_CPF.Text;
                c.Endereco = textBox_Endereco.Text;
                c.Cep = textBox_CEP.Text;

                if (string.IsNullOrWhiteSpace(c.Nome))
                {
                    MessageBox.Show("Nome inválido");
                    return;
                }
                else
                {
                    if (!int.TryParse(textBox_Nome.Text, out int nome))
                    {
                        c.Nome = textBox_Nome.Text;
                    }
                    else
                    {
                        MessageBox.Show("Nome inválido");
                        return;
                    }
                }

                if (string.IsNullOrWhiteSpace(c.Email))
                {
                    MessageBox.Show("Email inválido");
                    return;
                }
                else
                {
                    if (!int.TryParse(textBox_Email.Text, out int email))
                    {
                        c.Email = textBox_Email.Text;
                    }
                    else
                    {
                        MessageBox.Show("Email inválido");
                        return;
                    }
                }

                if (string.IsNullOrWhiteSpace(c.Endereco))
                {
                    MessageBox.Show("Endereço inválido");
                    return;
                }
                else
                {
                    if (!int.TryParse(textBox_Endereco.Text, out int endero))
                    {
                        c.Endereco = textBox_Endereco.Text;
                    }
                    else
                    {
                        MessageBox.Show("Endereço inválido");
                        return;
                    }
                }

                if (long.TryParse(textBox_Telefone.Text, out long telefone))
                {
                    c.Telefone = telefone.ToString();
                }
                else
                {
                    MessageBox.Show("Número de telefone inválido!");
                    return;
                }


                if (long.TryParse(textBox_CPF.Text, out long cpf))
                {
                    c.Cpf = cpf.ToString();
                }
                else
                {
                    MessageBox.Show("CPF inválido!");
                    return;
                }

                if (long.TryParse(textBox_CEP.Text, out long cep))
                {
                    c.Cep = cep.ToString();
                }
                else
                {
                    MessageBox.Show("CEP inválido!");
                    return;
                }

                contexto.Clientes.Add(c);
                contexto.SaveChanges();
                MessageBox.Show("Cadastro feito com sucesso!");

            }
        }

        private void button_CadastroNome_Click(object sender, EventArgs e)
        {
            cadastrarClientes();
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
