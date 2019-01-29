using FinancasPessoais.Main.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FinancasPessoais.Main.Domain.Repositories
{
    public interface ITransacaoRepository
    {
        Task InsertAsync(Transacao transacao);
        Task UpdateAsync(Transacao transacao);
        Task<Transacao> SearchByIdAsync(int id);
        Task<IEnumerable<Transacao>> SearchAllAsync();
    }
}
