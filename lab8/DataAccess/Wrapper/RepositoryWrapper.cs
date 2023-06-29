using Domain.Interfaces;
using OnlineShop.Models;
using DataAccess.Repositories;
using OnlineShop.Models;

namespace DataAccess.Wrapper
{
    public class RepositoryWrapper : Domain.Wrapper.IRepositoryWrapper
    {
        private OnlineShopContext _repoContext;

        private IUserRepository _user;
        public IUserRepository UserRepository
        { 
            get 
            { 
                if (_user == null)
                {
                    _user = new UserRepository(_repoContext);
                }
                return _user;
            } 
        }
        public RepositoryWrapper(OnlineShopContext repoContext)
        {
            _repoContext = repoContext;
        }
        public async Task Save()
        {
            await _repoContext.SaveChangesAsync();
        }
    }
}
