using GarageSoft.Application.Contracts.Persistence;
using GarageSoft.Domain.Entities;
using GarageSoft.Infrastructure.DbContexts;

namespace GarageSoft.Infrastructure.Repository;

public class ServicesReposity(GarageSoftContext _context) : GenericRepository<Service>(_context), IServiceRepository
{
}
