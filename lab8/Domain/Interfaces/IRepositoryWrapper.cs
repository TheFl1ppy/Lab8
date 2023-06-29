using Domain.Interfaces;

namespace Domain.Wrapper
{
    public interface IRepositoryWrapper
    {
        IUserRepository UserRepository { get; }
        Task Save();
    }
}
