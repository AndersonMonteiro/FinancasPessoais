using System;
using System.Collections.Generic;
using System.Text;

namespace FinancasPessoais.Main.Domain.Entities
{
    public class Comentario
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataATualizacao { get; set; }
        public int UsuarioId { get; set; }
        public Boolean Inativo { get; set; }
    }
}