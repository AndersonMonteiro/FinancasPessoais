using FinancasPessoais.Main.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FinancasPessoais.Main.Domain.Repositories
{
    public interface ILancamentoRepository
    {
        Task InsertAsync(Lancamento lancamento);
        Task UpdateAsync(Lancamento lancamento);
        Task<Lancamento> SearchByIdAsync(int id);
        Task<IEnumerable<Lancamento>> SearchAllAsync();
    }
}
