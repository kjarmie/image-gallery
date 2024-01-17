using Core.Data.Contracts;

namespace Core.Features.Image.Data;

public interface IImageQueryRepository : IQueryRepository<Domain.Entities.Image, Guid>
{
    
}