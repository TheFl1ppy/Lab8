using DataAccess.Interfaces;
using OnlineShop.Models;
using OnlineShop;

namespace DataAccess.Repositories
{
    public class UserRepository : RepositoryBase<User>, Domain.Interfaces.IUserRepository
    {
        public UserRepository(OnlineShopContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
