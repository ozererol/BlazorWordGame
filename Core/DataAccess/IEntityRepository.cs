using System.Collections.Generic;

namespace blazorWords.Core.Utilities.Results
{
    public interface IEntityRepository<T>
        where T : class, IEntity

    {
        Task<PagingResult<T>> GetListForPaging(GlobalFilterModel globalFilterModel, params Expression<Func<T, object>>[] includeEntities);
    }
}