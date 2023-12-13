namespace MiniERP
{
    partial class FormProdutos
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
            label1 = new Label();
            textBox_TipoProduto = new TextBox();
            textBox_Valor = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox_IdFornecedor = new TextBox();
            button_Salvar = new Button();
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
            panel2 = new Panel();
            label6 = new Label();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(848, 342);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(188, 32);
            label1.TabIndex = 0;
            label1.Text = "Tipo de produto";
            // 
            // textBox_TipoProduto
            // 
            textBox_TipoProduto.BackColor = Color.Gainsboro;
            textBox_TipoProduto.BorderStyle = BorderStyle.None;
            textBox_TipoProduto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_TipoProduto.Location = new Point(848, 379);
            textBox_TipoProduto.Margin = new Padding(4, 5, 4, 5);
            textBox_TipoProduto.Name = "textBox_TipoProduto";
            textBox_TipoProduto.Size = new Size(416, 32);
            textBox_TipoProduto.TabIndex = 1;
            // 
            // textBox_Valor
            // 
            textBox_Valor.BackColor = Color.Gainsboro;
            textBox_Valor.BorderStyle = BorderStyle.None;
            textBox_Valor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Valor.Location = new Point(848, 552);
            textBox_Valor.Margin = new Padding(4, 5, 4, 5);
            textBox_Valor.Name = "textBox_Valor";
            textBox_Valor.Size = new Size(416, 32);
            textBox_Valor.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(848, 515);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(195, 32);
            label2.TabIndex = 3;
            label2.Text = "Valor do produto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(848, 675);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(200, 32);
            label3.TabIndex = 4;
            label3.Text = "ID do Fornecedor";
            // 
            // textBox_IdFornecedor
            // 
            textBox_IdFornecedor.BackColor = Color.Gainsboro;
            textBox_IdFornecedor.BorderStyle = BorderStyle.None;
            textBox_IdFornecedor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_IdFornecedor.Location = new Point(848, 712);
            textBox_IdFornecedor.Margin = new Padding(4, 5, 4, 5);
            textBox_IdFornecedor.Name = "textBox_IdFornecedor";
            textBox_IdFornecedor.Size = new Size(416, 32);
            textBox_IdFornecedor.TabIndex = 5;
            // 
            // button_Salvar
            // 
            button_Salvar.BackColor = Color.Khaki;
            button_Salvar.FlatAppearance.BorderSize = 0;
            button_Salvar.FlatStyle = FlatStyle.Flat;
            button_Salvar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Salvar.Location = new Point(969, 787);
            button_Salvar.Margin = new Padding(4, 5, 4, 5);
            button_Salvar.Name = "button_Salvar";
            button_Salvar.Size = new Size(162, 59);
            button_Salvar.TabIndex = 6;
            button_Salvar.Text = "Salvar";
            button_Salvar.UseVisualStyleBackColor = false;
            button_Salvar.Click += button_Salvar_Click;
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
            menuStrip1.Size = new Size(2094, 38);
            menuStrip1.TabIndex = 17;
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
            // panel2
            // 
            panel2.BackColor = Color.Khaki;
            panel2.Controls.Add(label6);
            panel2.Location = new Point(-24, 1099);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(2140, 53);
            panel2.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(993, 15);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(187, 28);
            label6.TabIndex = 0;
            label6.Text = "© Omodei, Gustavo";
            // 
            // FormProdutos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Inserir_um_título__1_1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2094, 1151);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            Controls.Add(button_Salvar);
            Controls.Add(textBox_IdFornecedor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox_Valor);
            Controls.Add(textBox_TipoProduto);
            Controls.Add(label1);
            DoubleBuffered = true;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormProdutos";
            Text = "Produtos";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_TipoProduto;
        private TextBox textBox_Valor;
        private Label label2;
        private Label label3;
        private TextBox textBox_IdFornecedor;
        private Button button_Salvar;
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
        private Panel panel2;
        private Label label6;
    }
}