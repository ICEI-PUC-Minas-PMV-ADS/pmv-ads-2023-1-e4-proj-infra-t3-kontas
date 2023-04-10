using Kontas.API.Entities;
using Kontas.API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Kontas.API.Repositories
{
    public class ContaRepository : RepositoryBase<Conta>, IContaRepository
    {
        public ContaRepository(KontasDBContext context) : base(context) { }
    }
}
