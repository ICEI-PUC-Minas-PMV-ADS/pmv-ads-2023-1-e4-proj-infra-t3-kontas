using Kontas.API.Entities;
using Kontas.API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Kontas.API.Repositories
{
    public class StatusContaRepository : RepositoryBase<StatusConta>, IStatusContaRepository
    {
        public StatusContaRepository(KontasDBContext context) : base(context) { }
    }
}
