using System.Collections.Generic;

namespace blazorWords.Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext>
        : IEntityRepository<TEntity>
        where TEntity : class, IEntity
        where TContext : DbContext
    {
        public PagingResult<TEntity> GetListForPaging(int page, int rows, string propertyName, int asc, Expression<Func<TEntity, bool>> expression = null, params Expression<Func<TEntity, object>>[] includeEntities)
        {
            var list = Context.Set<TEntity>().AsQueryable();

            if (includeEntities.Length > 0)
                list = list.IncludeMultiple(includeEntities);

            if (expression != null)
                list = list.Where(expression).AsQueryable();

            if (propertyName != null && propertyName.Length > 0)
                list = asc == 1 ? list.AscOrDescOrder(ESort.ASC, propertyName) : list.AscOrDescOrder(ESort.DESC, propertyName);

            int totalCount = list.Count();

            var start = (page - 1) * rows;
            list = list.Skip(start).Take(rows);
            return new PagingResult<TEntity>(list.ToList(), totalCount, true, $"{totalCount} records listed.");
        }
    }
}