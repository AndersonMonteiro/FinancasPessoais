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
    public class TransacaoService : ITransacaoService
    {
        protected readonly ITransacaoRepository TransacaoRepository;

        public TransacaoService(ITransacaoRepository TransacaoRepository)
        {
            this.TransacaoRepository = TransacaoRepository;
        }

        public Task<Response> InsertAsync(Transacao transacao)
        {
            throw new NotImplementedException();
        }

        public Task<Response<IEnumerable<Transacao>>> SearchAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Response<Transacao>> SearchByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response> UpdateAsync(Transacao transacao)
        {
            throw new NotImplementedException();
        }
    }
}
