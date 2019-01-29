using System;
using System.Collections.Generic;
using System.Text;

namespace FinancasPessoais.Main.Domain.Entities
{
    public class Conta
    {
        public int Id { get; set; }
        public int ContaTipoId { get; set; }
        public string Descricao { get; set; }
        public decimal Saldo { get; set; }
        public int UsuarioId { get; set; }
        public int EnderecoId { get; set; }
        public int Agencia { get; set; }
        public int NumeroConta { get; set; }
        public Boolean Inativo { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataATualizacao { get; set; }
    }
}
