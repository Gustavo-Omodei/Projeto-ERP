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
    public partial class ConsultaFornecedor : Form
    {
        public ConsultaFornecedor()
        {
            InitializeComponent();
            ConfigureListView();
            listView1.HideSelection = false;
            consultar();
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
            List<Fornecedore> lista = new List<Fornecedore>();

            using (erpContext contexto = new erpContext())
            {
                lista = contexto.Fornecedores.ToList();

                foreach (var fornecedor in lista)
                {
                    string[] itens = { fornecedor.Id.ToString(), fornecedor.Nome, fornecedor.Email, fornecedor.RazaoSocial, fornecedor.Endereco, fornecedor.Telefone, fornecedor.CNPJ };
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
