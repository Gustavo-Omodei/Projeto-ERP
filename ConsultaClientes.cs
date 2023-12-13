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
    public partial class ConsultaClientes : Form
    {
        public ConsultaClientes()
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
            List<Cliente> lista = new List<Cliente>();

            using (erpContext contexto = new erpContext())
            {
                
                lista = contexto.Clientes.ToList();

                foreach (var cliente in lista)
                {
                    string[] itens = { cliente.Id.ToString(), cliente.Nome, cliente.Email, cliente.Endereco, cliente.Cpf, cliente.Cep, cliente.Telefone.ToString() };
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