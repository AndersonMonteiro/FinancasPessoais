using System;
using System.Collections.Generic;
using System.Text;

namespace FinancasPessoais.Main.Domain.Entities
{
    public class TransacaoCategoria
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int TransacaoTipoId { get; set; }
    }
}
