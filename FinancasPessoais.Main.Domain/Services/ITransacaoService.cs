using FinancasPessoais.Infrastructure.CrossCutting.Response;
using FinancasPessoais.Main.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FinancasPessoais.Main.Domain.Services
{
    public interface ITransacaoService
    {
        Task<Response> InsertAsync(Transacao transacao);
        Task<Response> UpdateAsync(Transacao transacao);
        Task<Response<Transacao>> SearchByIdAsync(int id);
        Task<Response<IEnumerable<Transacao>>> SearchAllAsync();
    }
}