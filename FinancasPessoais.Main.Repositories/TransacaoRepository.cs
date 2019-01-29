using FinancasPessoais.Infrastructure.DatabaseHelper;
using FinancasPessoais.Main.Domain.Entities;
using FinancasPessoais.Main.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinancasPessoais.Main.Repositories
{
    public class TransacaoRepository : ITransacaoRepository
    {
        protected readonly IPostgreSqlConnectionFactory postgreSqlConnectionFactory;

        public TransacaoRepository(IPostgreSqlConnectionFactory postgreSqlConnectionFactory)
        {
            this.postgreSqlConnectionFactory = postgreSqlConnectionFactory;
        }

        public Task InsertAsync(Transacao transacao)
        {
            using ( var conn = postgreSqlConnectionFactory.CreateConnection(ConnectionName.FINANCAS))
            {
                throw new NotImplementedException();
            }
        }

        public Task<IEnumerable<Transacao>> SearchAllAsync()
        {
            using (var conn = postgreSqlConnectionFactory.CreateConnection(ConnectionName.FINANCAS))
            {
                throw new NotImplementedException();
            }
        }

        public Task<Transacao> SearchByIdAsync(int id)
        {
            using (var conn = postgreSqlConnectionFactory.CreateConnection(ConnectionName.FINANCAS))
            {
                throw new NotImplementedException();
            }
        }

        public Task UpdateAsync(Transacao transacao)
        {
            using (var conn = postgreSqlConnectionFactory.CreateConnection(ConnectionName.FINANCAS))
            {
                throw new NotImplementedException();
            }
        }
    }
}
