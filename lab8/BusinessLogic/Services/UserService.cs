using Domain.Interfaces;
using OnlineShop.Models;
using Domain.Wrapper;

namespace BusinessLogic.Services
{
    public class UserService : IUserService
    {
        private IRepositoryWrapper _repositoryWrapper;
        public UserService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }
        public async Task<List<User>> GetAll()
        {
            return await _repositoryWrapper.UserRepository.FindAll();
        }
public async Task<User> GetById(int id)
        {
            var user = await _repositoryWrapper.UserRepository
            .FindByCondition(x => x.UsersId == id);
            return user.First();
        }
        public async Task Create(User model)
        {
            await _repositoryWrapper.UserRepository.Create(model);
            _repositoryWrapper.Save();
        }
        public async Task Update(User model)
        {
            _repositoryWrapper.UserRepository.Update(model);
            _repositoryWrapper.Save();
        }
        public async Task Delete(int id)
        {
            var user = await _repositoryWrapper.UserRepository
            .FindByCondition(x => x.UsersId == id);
            _repositoryWrapper.UserRepository.Delete(user.First());
            _repositoryWrapper.Save();
        }
    }
}