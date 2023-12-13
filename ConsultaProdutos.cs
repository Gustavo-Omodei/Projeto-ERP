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
    public partial class ConsultaProdutos : Form
    {
        public ConsultaProdutos()
        {
            InitializeComponent();
            consultar();
            ConfigureListView();
        }

        private void ConfigureListView()
        {
            listView1.HideSelection = false;
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;
        }

        private void consultar()
        {
            List<Produto> lista = new List<Produto>();

            using (erpContext contexto = new erpContext())
            {
                lista = contexto.Produtos.ToList();

                foreach (var produto in lista)
                {
                    string[] itens = { produto.Id.ToString(), produto.TipoProduto, produto.Valor.ToString(), produto.IdFornecedor.ToString() };
                    listView1.Items.Add(new ListViewItem(itens));
                }

                foreach (ListViewItem item in listView1.Items)
                {
                    if ((item.Index % 2) == 0)
                    {
                        item.BackColor = Color.LightCoral;

                    }
                    else
                    {
                        item.BackColor = Color.White;
                    }
                }
            }
        }
    }
}
