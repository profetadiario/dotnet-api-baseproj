using Boilerplate.Core.Interfaces;
using Boilerplate.Core.Models;
using Boilerplate.Infra.Context;

namespace Boilerplate.Infra.Repository
{
    public class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository
    {
        private readonly AppDbContext _context;

        public FornecedorRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
