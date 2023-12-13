using System;
using System.Collections.Generic;

namespace MiniERP
{
    public partial class Fornecedore
    {
        public Fornecedore()
        {
            Produtos = new HashSet<Produto>();
        }

        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public string? Endereco { get; set; }
        public string? CNPJ { get; set; }
        public string RazaoSocial { get; set; } = null!;

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
