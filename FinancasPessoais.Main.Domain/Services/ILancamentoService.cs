using FinancasPessoais.Infrastructure.CrossCutting.Response;
using FinancasPessoais.Main.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FinancasPessoais.Main.Domain.Services
{
    public interface ILancamentoService
    {
        Task<Response> InsertAsync(Lancamento lancamento);
        Task<Response> UpdateAsync(Lancamento lancamento);
        Task<Response<Lancamento>> SearchByIdAsync(int id);
        Task<Response<IEnumerable<Lancamento>>> SearchAllAsync();
    }
}