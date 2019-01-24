using FinancasPessoais.Infrastructure.DatabaseHelper;
using FinancasPessoais.Main.Domain.Entities;
using FinancasPessoais.Main.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinancasPessoais.Main.Repositories
{
    public class LancamentoRepository : ILancamentoRepository
    {
        protected readonly IPostgreSqlConnectionFactory postgreSqlConnectionFactory;

        public LancamentoRepository(IPostgreSqlConnectionFactory postgreSqlConnectionFactory)
        {
            this.postgreSqlConnectionFactory = postgreSqlConnectionFactory;
        }

        public Task InsertAsync(Lancamento lancamento)
        {
            using ( var conn = postgreSqlConnectionFactory.CreateConnection(ConnectionName.FINANCAS))
            {
                throw new NotImplementedException();
            }
        }

        public Task<IEnumerable<Lancamento>> SearchAllAsync()
        {
            using (var conn = postgreSqlConnectionFactory.CreateConnection(ConnectionName.FINANCAS))
            {
                throw new NotImplementedException();
            }
        }

        public Task<Lancamento> SearchByIdAsync(int id)
        {
            using (var conn = postgreSqlConnectionFactory.CreateConnection(ConnectionName.FINANCAS))
            {
                throw new NotImplementedException();
            }
        }

        public Task UpdateAsync(Lancamento lancamento)
        {
            using (var conn = postgreSqlConnectionFactory.CreateConnection(ConnectionName.FINANCAS))
            {
                throw new NotImplementedException();
            }
        }
    }
}
