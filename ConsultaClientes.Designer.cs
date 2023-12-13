namespace MiniERP
{
    partial class ConsultaClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listView1 = new ListView();
            id_Clientes = new ColumnHeader();
            nome_Clientes = new ColumnHeader();
            email_Clientes = new ColumnHeader();
            endereco_Clientes = new ColumnHeader();
            cpf_CLientes = new ColumnHeader();
            telefone_Clientes = new ColumnHeader();
            cep_Clientes = new ColumnHeader();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Activation = ItemActivation.OneClick;
            listView1.Columns.AddRange(new ColumnHeader[] { id_Clientes, nome_Clientes, email_Clientes, endereco_Clientes, cpf_CLientes, telefone_Clientes, cep_Clientes });
            listView1.Dock = DockStyle.Fill;
            listView1.LabelWrap = false;
            listView1.Location = new Point(0, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(1024, 651);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // id_Clientes
            // 
            id_Clientes.Text = "ID";
            id_Clientes.Width = 40;
            // 
            // nome_Clientes
            // 
            nome_Clientes.Text = "Nome";
            nome_Clientes.Width = 150;
            // 
            // email_Clientes
            // 
            email_Clientes.Text = "Email";
            email_Clientes.Width = 200;
            // 
            // endereco_Clientes
            // 
            endereco_Clientes.Text = "Endereço";
            endereco_Clientes.Width = 150;
            // 
            // cpf_CLientes
            // 
            cpf_CLientes.Text = "CPF";
            cpf_CLientes.Width = 150;
            // 
            // telefone_Clientes
            // 
            telefone_Clientes.Text = "Telefone";
            telefone_Clientes.Width = 150;
            // 
            // cep_Clientes
            // 
            cep_Clientes.Text = "CEP";
            cep_Clientes.Width = 150;
            // 
            // ConsultaClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 651);
            Controls.Add(listView1);
            Name = "ConsultaClientes";
            Text = "ConsultaClientes";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader id_Clientes;
        private ColumnHeader nome_Clientes;
        private ColumnHeader email_Clientes;
        private ColumnHeader endereco_Clientes;
        private ColumnHeader telefone_Clientes;
        private ColumnHeader cep_Clientes;
        private ColumnHeader cpf_CLientes;
    }
}