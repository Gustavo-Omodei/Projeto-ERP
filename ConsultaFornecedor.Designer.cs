namespace MiniERP
{
    partial class ConsultaFornecedor
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
            id_Fornecedor = new ColumnHeader();
            Nome = new ColumnHeader();
            Email = new ColumnHeader();
            RazaoSocial = new ColumnHeader();
            Endereço = new ColumnHeader();
            Telefone = new ColumnHeader();
            CNPJ = new ColumnHeader();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { id_Fornecedor, Nome, Email, RazaoSocial, Endereço, Telefone, CNPJ });
            listView1.Dock = DockStyle.Fill;
            listView1.Location = new Point(0, 0);
            listView1.Margin = new Padding(4, 5, 4, 5);
            listView1.Name = "listView1";
            listView1.Size = new Size(1817, 1135);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // id_Fornecedor
            // 
            id_Fornecedor.Text = "ID";
            // 
            // Nome
            // 
            Nome.Text = "Nome";
            Nome.Width = 200;
            // 
            // Email
            // 
            Email.Text = "Email";
            Email.Width = 250;
            // 
            // RazaoSocial
            // 
            RazaoSocial.Text = "Razão Social";
            RazaoSocial.Width = 200;
            // 
            // Endereço
            // 
            Endereço.Text = "Endereço";
            Endereço.Width = 200;
            // 
            // Telefone
            // 
            Telefone.Text = "Telefone";
            Telefone.Width = 100;
            // 
            // CNPJ
            // 
            CNPJ.Text = "CNPJ";
            CNPJ.Width = 100;
            // 
            // ConsultaFornecedor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1817, 1135);
            Controls.Add(listView1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ConsultaFornecedor";
            Text = "ConsultaFornecedor";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader id_Fornecedor;
        private ColumnHeader Nome;
        private ColumnHeader Email;
        private ColumnHeader RazaoSocial;
        private ColumnHeader Endereço;
        private ColumnHeader Telefone;
        private ColumnHeader CNPJ;
    }
}