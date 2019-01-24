using FinancasPessoais.Infrastructure.CrossCutting.Response;
using FinancasPessoais.Main.Domain.Entities;
using FinancasPessoais.Main.Domain.Repositories;
using FinancasPessoais.Main.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FinancasPessoais.Main.Services
{
    public class LancamentoService : ILancamentoService
    {
        protected readonly ILancamentoRepository lancamentoRepository;

        public LancamentoService(ILancamentoRepository lancamentoRepository)
        {
            this.lancamentoRepository = lancamentoRepository;
        }

        public Task<Response> InsertAsync(Lancamento lancamento)
        {
            throw new NotImplementedException();
        }

        public Task<Response<IEnumerable<Lancamento>>> SearchAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Response<Lancamento>> SearchByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response> UpdateAsync(Lancamento lancamento)
        {
            throw new NotImplementedException();
        }
    }
}
