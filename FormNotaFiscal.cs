using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Encodings.Web;
using System.Drawing.Drawing2D;

namespace MiniERP
{
    public partial class FormNotaFiscal : Form
    {
        public FormNotaFiscal()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath forma = new GraphicsPath();
            forma.AddEllipse(0, 0, 100, 100);
        }

        private bool notaCadastrada = false;
        private void button1_Click(object sender, EventArgs e)
        {
            cadastrarNotas();
            if (notaCadastrada)
            {
                DialogResult resultado = MessageBox.Show("Gostaria de gerar o arquivo PDF?", "titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    using (var conexao = new SqlConnection("Data Source=localhost;Initial Catalog=erp;User ID=usuarioERP;password=senha1234@;language=Portuguese;"))
                    {
                        conexao.Open();
                        NotaFiscal nota = new NotaFiscal();
                        Produto p = new Produto();

                        int idCliente = int.Parse(textBox_Nome.Text);
                        int idProduto = int.Parse(textBox_Produto.Text);
                        int idFornecedor = p.IdFornecedor;

                        //Query Nota
                        string queryNota = "SELECT notaFiscal.id FROM notaFiscal,clientes, produtos WHERE notaFiscal.id_Cliente = @IdCliente and notaFiscal.id_Produto = @IdProduto";

                        //Query Cliente
                        string queryNomeCliente = "SELECT nome FROM clientes WHERE clientes.id = @IdCliente";
                        string queryEmailCliente = "SELECT email FROM clientes WHERE clientes.id = @idEmail";
                        string queryEndereco = "SELECT endereco FROM clientes WHERE clientes.id = @IdCliente";
                        string queryCPF = "SELECT cpf FROM clientes WHERE clientes.id = @IdCliente";
                        string queryTelefone = "SELECT telefone FROM clientes WHERE clientes.id = @IdCliente";
                        string queryCEP = "SELECT cep FROM clientes WHERE clientes.id = @IdCliente";

                        //Query Produtos
                        string queryProduto = "SELECT tipoProduto FROM produtos WHERE produtos.id = @IdProduto";
                        string queryValor = "SELECT valor FROM produtos WHERE produtos.id = @idValor";

                        //Query Fornecedor
                        string queryFornecedor = "select razaoSocial from fornecedores, produtos where fornecedores.id = produtos.id_Fornecedor";

                        //using Nota
                        using (var comandoNota = new SqlCommand(queryNota, conexao))
                        //Using Cliente
                        using (var comandoNomeCliente = new SqlCommand(queryNomeCliente, conexao))
                        using (var comandoEmail = new SqlCommand(queryEmailCliente, conexao))
                        using (var comandoEndereco = new SqlCommand(queryEndereco, conexao))
                        using (var comandoTelefone = new SqlCommand(queryTelefone, conexao))
                        using (var comandoCPF = new SqlCommand(queryCPF, conexao))
                        using (var comandoCEP = new SqlCommand(queryCEP, conexao))
                        //Using Produto
                        using (var comandoProduto = new SqlCommand(queryProduto, conexao))
                        using (var comandoValor = new SqlCommand(queryValor, conexao))
                        //Using Fornecedor
                        using (var comandoFornecedor = new SqlCommand(queryFornecedor, conexao))
                        {
                            comandoNota.Parameters.AddWithValue("@IdCliente", idCliente);
                            comandoNota.Parameters.AddWithValue("@IdProduto", idProduto);
                            comandoNomeCliente.Parameters.AddWithValue("@IdCliente", idCliente);
                            comandoEmail.Parameters.AddWithValue("@IdEmail", idCliente);
                            comandoEndereco.Parameters.AddWithValue("@IdCliente", idCliente);
                            comandoTelefone.Parameters.AddWithValue("@IdCliente", idCliente);
                            comandoCPF.Parameters.AddWithValue("@IdCliente", idCliente);
                            comandoCEP.Parameters.AddWithValue("@IdCliente", idCliente);
                            comandoProduto.Parameters.AddWithValue("@IdProduto", idProduto);
                            comandoValor.Parameters.AddWithValue("@IdValor", idProduto);
                            comandoFornecedor.Parameters.AddWithValue("@id_Fornecedor", idFornecedor);

                            //String Nome   
                            string idNota = (string)comandoNota.ExecuteScalar().ToString();
                            //String Nome
                            string nomeCliente = (string)comandoNomeCliente.ExecuteScalar();
                            string emailCleinte = (string)comandoEmail.ExecuteScalar();
                            string endereco = (string)comandoEndereco.ExecuteScalar();
                            string telefone = (string)comandoTelefone.ExecuteScalar();
                            string cpf = (string)comandoCPF.ExecuteScalar();
                            string cep = (string)comandoCEP.ExecuteScalar();

                            //String Produto

                            string nomeProduto = (string)comandoProduto.ExecuteScalar();
                            string valorProduto = (string)comandoValor.ExecuteScalar().ToString();

                            //String Fornecedor
                            string nomeFornecedor = (string)comandoFornecedor.ExecuteScalar();


                            List<NotaFiscal> notas = new List<NotaFiscal>();
                            NotaFiscal notaFiscal = new NotaFiscal();
                            notaFiscal.Id = int.Parse(idNota);
                            notaFiscal.IdCliente = idCliente;
                            notaFiscal.IdProduto = idProduto;

                            notas.Add(notaFiscal);


                            gerarArquivo(notas, idNota, nomeCliente, emailCleinte, endereco, telefone, cpf, cep, nomeProduto, valorProduto, nomeFornecedor);

                        }
                    }
                }
            }
        }

        private void gerarArquivo(List<NotaFiscal> nota, string idNota, string nomeCliente, string emailCliente, string endereco, string telefone, string cpf, string cep,
            string nomeProduto, string valorProduto, string nomeFornecedor)
        {
            StringBuilder sb = new StringBuilder();
            nota.ForEach(x => sb.AppendLine($"#Nota Fiscal: {idNota} \n" +
                $"Nome: {nomeCliente}\n" +
                $"Email: {emailCliente}\n" +
                $"CPF: {cpf}\n" +
                $"Telefone: {telefone}\n" +
                $"Endereco: {endereco}\n" +
                $"CEP: {cep}\n" +
                $"Produto: {nomeProduto}\n" +
                $"Valor do produto: {valorProduto}\n" +
                $"Fornecedor: {nomeFornecedor}"));
            var filePath = @"C:\Users\a891607\Desktop\teste\Nota" + idNota + ".pdf";
            File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);

            MessageBox.Show("Arquivo PDF criado com sucesso");
        }

        private void cadastrarNotas()
        {
            using (var contexto = new erpContext())
            {
                NotaFiscal nota = new NotaFiscal();


                if (int.TryParse(textBox_Nome.Text, out int clienteID))
                {
                    nota.IdCliente = clienteID;
                    Cliente cliente = contexto.Clientes.Find(clienteID);


                    if (cliente == null)
                    {
                        MessageBox.Show("Cliente não encontrado");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Cliente inválido");
                    return;
                }

                if (int.TryParse(textBox_Produto.Text, out int ProdutoID))
                {
                    nota.IdProduto = ProdutoID;
                    Produto produto = contexto.Produtos.Find(ProdutoID);


                    if (produto == null)
                    {
                        MessageBox.Show("Produto não encontrado");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Produto inválido");
                    return;
                }
                contexto.NotaFiscals.Add(nota);
                contexto.SaveChanges();
                MessageBox.Show("Nota cadastrada com sucesso");
                notaCadastrada = true;
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
