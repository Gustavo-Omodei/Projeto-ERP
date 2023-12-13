namespace MiniERP
{
    partial class FormClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            label1 = new Label();
            label2 = new Label();
            textBox_Nome = new TextBox();
            textBox_Email = new TextBox();
            button_CadastroNome = new Button();
            label3 = new Label();
            label4 = new Label();
            textBox_CPF = new TextBox();
            textBox_Telefone = new TextBox();
            textBox_Endereco = new TextBox();
            textBox_CEP = new TextBox();
            label5 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            menuStrip1 = new MenuStrip();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            fornecedoresToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem1 = new ToolStripMenuItem();
            consultarToolStripMenuItem1 = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem2 = new ToolStripMenuItem();
            consultarToolStripMenuItem2 = new ToolStripMenuItem();
            notaFiscalToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem3 = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(335, 274);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 32);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(335, 402);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 32);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // textBox_Nome
            // 
            textBox_Nome.BackColor = Color.Gainsboro;
            textBox_Nome.BorderStyle = BorderStyle.None;
            textBox_Nome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Nome.Location = new Point(335, 307);
            textBox_Nome.Margin = new Padding(4, 5, 4, 5);
            textBox_Nome.Name = "textBox_Nome";
            textBox_Nome.Size = new Size(508, 32);
            textBox_Nome.TabIndex = 2;
            // 
            // textBox_Email
            // 
            textBox_Email.BackColor = Color.Gainsboro;
            textBox_Email.BorderStyle = BorderStyle.None;
            textBox_Email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Email.Location = new Point(335, 439);
            textBox_Email.Margin = new Padding(4, 5, 4, 5);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(507, 32);
            textBox_Email.TabIndex = 3;
            // 
            // button_CadastroNome
            // 
            button_CadastroNome.BackColor = Color.Khaki;
            button_CadastroNome.BackgroundImageLayout = ImageLayout.None;
            button_CadastroNome.FlatAppearance.BorderColor = Color.Black;
            button_CadastroNome.FlatAppearance.BorderSize = 0;
            button_CadastroNome.FlatStyle = FlatStyle.Flat;
            button_CadastroNome.Location = new Point(818, 721);
            button_CadastroNome.Margin = new Padding(4, 5, 4, 5);
            button_CadastroNome.Name = "button_CadastroNome";
            button_CadastroNome.Size = new Size(203, 52);
            button_CadastroNome.TabIndex = 4;
            button_CadastroNome.Text = "Cadastrar";
            button_CadastroNome.UseVisualStyleBackColor = false;
            button_CadastroNome.Click += button_CadastroNome_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(996, 274);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 32);
            label3.TabIndex = 5;
            label3.Text = "CPF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(996, 402);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(106, 32);
            label4.TabIndex = 6;
            label4.Text = "Telefone";
            // 
            // textBox_CPF
            // 
            textBox_CPF.BackColor = Color.Gainsboro;
            textBox_CPF.BorderStyle = BorderStyle.None;
            textBox_CPF.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_CPF.Location = new Point(996, 311);
            textBox_CPF.Margin = new Padding(4, 5, 4, 5);
            textBox_CPF.MaxLength = 40000000;
            textBox_CPF.Name = "textBox_CPF";
            textBox_CPF.Size = new Size(507, 32);
            textBox_CPF.TabIndex = 7;
            // 
            // textBox_Telefone
            // 
            textBox_Telefone.BackColor = Color.Gainsboro;
            textBox_Telefone.BorderStyle = BorderStyle.None;
            textBox_Telefone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Telefone.Location = new Point(996, 439);
            textBox_Telefone.Margin = new Padding(4, 5, 4, 5);
            textBox_Telefone.MaxLength = 40000;
            textBox_Telefone.Name = "textBox_Telefone";
            textBox_Telefone.Size = new Size(507, 32);
            textBox_Telefone.TabIndex = 8;
            // 
            // textBox_Endereco
            // 
            textBox_Endereco.BackColor = Color.Gainsboro;
            textBox_Endereco.BorderStyle = BorderStyle.None;
            textBox_Endereco.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Endereco.Location = new Point(336, 566);
            textBox_Endereco.Margin = new Padding(4, 5, 4, 5);
            textBox_Endereco.Name = "textBox_Endereco";
            textBox_Endereco.Size = new Size(507, 32);
            textBox_Endereco.TabIndex = 9;
            // 
            // textBox_CEP
            // 
            textBox_CEP.BackColor = Color.Gainsboro;
            textBox_CEP.BorderStyle = BorderStyle.None;
            textBox_CEP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_CEP.Location = new Point(996, 566);
            textBox_CEP.Margin = new Padding(4, 5, 4, 5);
            textBox_CEP.Name = "textBox_CEP";
            textBox_CEP.Size = new Size(507, 32);
            textBox_CEP.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(336, 529);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(113, 32);
            label5.TabIndex = 11;
            label5.Text = "Endereço";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(996, 529);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(54, 32);
            label6.TabIndex = 12;
            label6.Text = "CEP";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCoral;
            panel2.Location = new Point(-39, 1137);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(2160, 58);
            panel2.TabIndex = 14;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Khaki;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { clienteToolStripMenuItem, fornecedoresToolStripMenuItem, produtosToolStripMenuItem, notaFiscalToolStripMenuItem, ajudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(1924, 38);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem, consultarToolStripMenuItem });
            clienteToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(88, 32);
            clienteToolStripMenuItem.Text = "Cliente";
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(197, 36);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            cadastrarToolStripMenuItem.Click += cadastrarToolStripMenuItem_Click;
            // 
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(197, 36);
            consultarToolStripMenuItem.Text = "Consultar";
            consultarToolStripMenuItem.Click += consultarToolStripMenuItem_Click;
            // 
            // fornecedoresToolStripMenuItem
            // 
            fornecedoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem1, consultarToolStripMenuItem1 });
            fornecedoresToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            fornecedoresToolStripMenuItem.Size = new Size(146, 32);
            fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // cadastrarToolStripMenuItem1
            // 
            cadastrarToolStripMenuItem1.Name = "cadastrarToolStripMenuItem1";
            cadastrarToolStripMenuItem1.Size = new Size(197, 36);
            cadastrarToolStripMenuItem1.Text = "Cadastrar";
            cadastrarToolStripMenuItem1.Click += cadastrarToolStripMenuItem1_Click;
            // 
            // consultarToolStripMenuItem1
            // 
            consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            consultarToolStripMenuItem1.Size = new Size(197, 36);
            consultarToolStripMenuItem1.Text = "Consultar";
            consultarToolStripMenuItem1.Click += consultarToolStripMenuItem1_Click;
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem2, consultarToolStripMenuItem2 });
            produtosToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(108, 32);
            produtosToolStripMenuItem.Text = "Produtos";
            // 
            // cadastrarToolStripMenuItem2
            // 
            cadastrarToolStripMenuItem2.Name = "cadastrarToolStripMenuItem2";
            cadastrarToolStripMenuItem2.Size = new Size(197, 36);
            cadastrarToolStripMenuItem2.Text = "Cadastrar";
            cadastrarToolStripMenuItem2.Click += cadastrarToolStripMenuItem2_Click;
            // 
            // consultarToolStripMenuItem2
            // 
            consultarToolStripMenuItem2.Name = "consultarToolStripMenuItem2";
            consultarToolStripMenuItem2.Size = new Size(197, 36);
            consultarToolStripMenuItem2.Text = "Consultar";
            consultarToolStripMenuItem2.Click += consultarToolStripMenuItem2_Click;
            // 
            // notaFiscalToolStripMenuItem
            // 
            notaFiscalToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem3 });
            notaFiscalToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            notaFiscalToolStripMenuItem.Name = "notaFiscalToolStripMenuItem";
            notaFiscalToolStripMenuItem.Size = new Size(124, 32);
            notaFiscalToolStripMenuItem.Text = "Nota Fiscal";
            // 
            // cadastrarToolStripMenuItem3
            // 
            cadastrarToolStripMenuItem3.Name = "cadastrarToolStripMenuItem3";
            cadastrarToolStripMenuItem3.Size = new Size(197, 36);
            cadastrarToolStripMenuItem3.Text = "Cadastrar";
            cadastrarToolStripMenuItem3.Click += cadastrarToolStripMenuItem3_Click;
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sobreToolStripMenuItem });
            ajudaToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(79, 32);
            ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(166, 36);
            sobreToolStripMenuItem.Text = "Sobre";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 948);
            Controls.Add(menuStrip1);
            Controls.Add(panel2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox_CEP);
            Controls.Add(textBox_Endereco);
            Controls.Add(textBox_Telefone);
            Controls.Add(textBox_CPF);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button_CadastroNome);
            Controls.Add(textBox_Email);
            Controls.Add(textBox_Nome);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormClientes";
            Text = "Clientes";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox_Nome;
        private TextBox textBox_Email;
        private Button button_CadastroNome;
        private Label label3;
        private Label label4;
        private TextBox textBox_CPF;
        private TextBox textBox_Telefone;
        private TextBox textBox_Endereco;
        private TextBox textBox_CEP;
        private Label label5;
        private Label label6;
        private Panel panel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem fornecedoresToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem1;
        private ToolStripMenuItem consultarToolStripMenuItem1;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem2;
        private ToolStripMenuItem consultarToolStripMenuItem2;
        private ToolStripMenuItem notaFiscalToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem3;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
    }
}