using System;
using System.Collections.Generic;

namespace MiniERP
{
    public partial class Produto
    {
        public Produto()
        {
            NotaFiscals = new HashSet<NotaFiscal>();
        }

        public int Id { get; set; }
        public string TipoProduto { get; set; } = null!;
        public decimal Valor { get; set; }
        public int IdFornecedor { get; set; }

        public virtual Fornecedore? IdFornecedorNavigation { get; set; }
        public virtual ICollection<NotaFiscal> NotaFiscals { get; set; }

        
    }
}
