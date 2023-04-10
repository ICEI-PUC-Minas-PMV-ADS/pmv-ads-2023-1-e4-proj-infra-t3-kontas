using Kontas.API.Entities;
using Kontas.API.Repositories.Interfaces;

namespace Kontas.API.Repositories
{
    public class ContaPagamentoRepository : RepositoryBase<ContaPagamento>, IContaPagamentoRepository
    {
        public ContaPagamentoRepository(KontasDBContext context) : base(context) {}
    }
}
