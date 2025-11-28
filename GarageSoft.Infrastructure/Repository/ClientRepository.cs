using GarageSoft.Application.Contracts.Persistence;
using GarageSoft.Domain.Entities;
using GarageSoft.Infrastructure.DbContexts;
namespace GarageSoft.Infrastructure.Repository;

public class ClientRepository(GarageSoftContext context) : GenericRepository<Client>(context), IClientRepository
{

}
