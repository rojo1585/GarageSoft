using GarageSoft.Infrastructure.DbContexts;

namespace GarageSoft.Infrastructure.Repository;

public class VehicleRepository(GarageSoftContext _context ) : GenericRepository<Domain.Entities.Vehicle>(_context), Application.Contracts.Persistence.IVehicleRepository
{
}
