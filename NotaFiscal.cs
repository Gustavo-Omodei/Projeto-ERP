 using System;
using System.Collections.Generic;

namespace MiniERP
{
    public partial class NotaFiscal
    {
        public int Id { get; set; }
        public int? IdCliente { get; set; }
        public int? IdProduto { get; set; }

        public virtual Cliente? IdClienteNavigation { get; set; }
        public virtual Produto? IdProdutoNavigation { get; set; }
    }
}
