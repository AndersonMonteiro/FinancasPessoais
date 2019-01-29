using System;
using System.Collections.Generic;
using System.Text;

namespace FinancasPessoais.Main.Domain.Entities
{
    public class Transacao
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string Descricao { get; set; }
        public int TransacaoCategoriaId { get; set; }
        public int FormaPagamentoId { get; set; }
        public int PrioridadeId { get; set; }
        public int QuantidadeParcelas { get; set; }
        public int LimiteParcelas { get; set; }
        public Boolean Inativo { get; set; }
        public DateTime DataAquisicao { get; set; }
        public DateTime DataPagamentoLimite { get; set; }
        public DateTime DataPagamentoEfetivado { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal ValorEfetivado { get; set; }
        public int TransacaoStatusId { get; set; }
        public int ContaOrigemId { get; set; }
    }
}