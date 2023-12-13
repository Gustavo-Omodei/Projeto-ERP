//using Microsoft.Data.SqlClient;
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace MiniERP
//{
//    public partial class FormNotaFiscal : Form
//    {
//        public FormNotaFiscal()
//        {
//            InitializeComponent();
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {

//            using (var conexao = new SqlConnection("Data Source=localhost;Initial Catalog=erp;User ID=usuarioERP;password=senha1234@;language=Portuguese;"))
//            {
//                conexao.Open();
//                NotaFiscal nota = new NotaFiscal();

//                int idNotaFiscal = nota.Id;
//                int idCliente = int.Parse(textBox_Nome.Text);
//                int idEmail = idCliente;
//                int idProduto = int.Parse(textBox_Produto.Text);
//                int idValor = idProduto;
//                int teste = idCliente;

//                string queryCliente = "SELECT nome FROM clientes WHERE clientes.id = @IdCliente";
//                string queryEmailCliente = "SELECT email FROM clientes WHERE clientes.id = @idEmail";
//                string queryProduto = "SELECT tipoProduto FROM produtos WHERE produtos.id = @IdProduto";
//                string queryValor = "SELECT valor FROM produtos WHERE produtos.id = @idValor";
//                string queryNota = "SELECT notaFiscal.id FROM notaFiscal,clientes, produtos WHERE notaFiscal.id_Cliente = @teste and notaFiscal.id_Produto = @IdProduto";

//                using (var comandoNota = new SqlCommand(queryNota, conexao))
//                using (var comandoCliente = new SqlCommand(queryCliente, conexao))
//                using (var comandoEmail = new SqlCommand(queryEmailCliente, conexao))
//                using (var comandoProduto = new SqlCommand(queryProduto, conexao))
//                using (var comandoValor = new SqlCommand(queryValor, conexao))
//                {


//                    comandoNota.Parameters.AddWithValue("@idNotaFiscal", idNotaFiscal);
//                    comandoCliente.Parameters.AddWithValue("@IdCliente", idCliente);
//                    comandoEmail.Parameters.AddWithValue("@idEmail", idEmail);
//                    comandoProduto.Parameters.AddWithValue("@IdProduto", idProduto);
//                    comandoValor.Parameters.AddWithValue("@idValor", idValor);

//                    string idNota = (string)comandoNota.ExecuteScalar().ToString();
//                    string nomeCliente = (string)comandoCliente.ExecuteScalar();
//                    string emailCleinte = (string)comandoEmail.ExecuteScalar();
//                    string nomeProduto = (string)comandoProduto.ExecuteScalar();
//                    string valorProduto = (string)comandoValor.ExecuteScalar().ToString();

//                    if (nomeCliente == null || nomeProduto == null)
//                    {
//                        MessageBox.Show("Cliente ou produto não encontrado.");
//                        return;
//                    }

//                    List<NotaFiscal> notas = new List<NotaFiscal>();
//                    NotaFiscal notaFiscal = new NotaFiscal();
//                    notaFiscal.IdCliente = idCliente;
//                    notaFiscal.IdProduto = idProduto;
//                    notas.Add(notaFiscal);

//                    colocarListaText(notas, idNota, nomeCliente, emailCleinte, nomeProduto, valorProduto);
//                }
//            }

//            //cadastrarNotas();
//        }

//        private void colocarListaText(List<NotaFiscal> lista, string idNota, string nomeCliente, string emailCliente, string nomeProduto, string valorProduto)
//        {
//            foreach (var notaFiscal in lista)
//            {
//                string[] itens = { idNota, nomeCliente, emailCliente, nomeProduto, valorProduto };
//                listView1.Items.Add(new ListViewItem(itens));
//            }
//        }


//        //private void cadastrarNotas()
//        //{
//        //    using (var contexto = new erpContext())
//        //    {
//        //        int idCliente = int.Parse(textBox_Nome.Text);
//        //        int idProduto = int.Parse(textBox_Produto.Text);

//        //        Cliente cliente = contexto.Clientes.Find(idCliente);
//        //        Produto produto = contexto.Produtos.Find(idProduto);

//        //        if (cliente == null || produto == null)
//        //        {
//        //            MessageBox.Show("Cliente ou produto não encontrado.");
//        //            return;
//        //        }
//        //        NotaFiscal n = new NotaFiscal();
//        //        n.IdCliente = int.Parse(textBox_Nome.Text);
//        //        n.IdProduto = int.Parse(textBox_Produto.Text);


//        //        contexto.NotaFiscals.Add(n);
//        //        contexto.SaveChanges();
//        //        MessageBox.Show("Cadastro feito com sucesso!");
//        //    }
//        //}
//    }
//}
