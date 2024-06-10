using Entities.Interfaces;

namespace BLL.Shared.Interfaces;

public interface ICrudService<T> : ICreateService<T>, IReadService<T>, IUpdateService<T>, IDeleteService<T> where T : ICrudEntity
{
    
}