using System;
using System.Collections.Generic;
using System.Text;

namespace FinancasPessoais.Main.Domain.Entities
{
    public class Lancamento
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string Descricao { get; set; }
        public int LancamentoCategoriaId { get; set; }
        public int FormaPagamentoId { get; set; }
        public int PrioridadeId { get; set; }
        public int QuantidadeParcelas { get; set; }
        public int LimiteParcelas { get; set; }
        public DateTime DataAquisicao { get; set; }
        public DateTime DataPagamento { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public decimal Valor { get; set; }
        public decimal ValorEfetivado { get; set; }
        public int LancamentoStatusId { get; set; }
        public int ContaOrigemId { get; set; }
        public int ContaDestinoId { get; set; }
    }
}
