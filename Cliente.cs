using System;
using System.Collections.Generic;

namespace MiniERP
{
    public partial class Cliente
    {
        public Cliente()
        {
            NotaFiscals = new HashSet<NotaFiscal>();
        }

        public int Id { get; set; }
        public string? Nome { get; set; } = null!;
        public string? Email { get; set; } = null!;
        public string? Endereco { get; set; } = null!;
        public string Telefone { get; set; }
        public string? Cep { get; set; }
        public string? Cpf { get; set; }



        public virtual ICollection<NotaFiscal> NotaFiscals { get; set; }
    }
}
