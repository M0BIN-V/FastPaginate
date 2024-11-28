namespace FastPaginate;

public static class QueryExtensions
{
    public static IQueryable<T> Paginate<T>
        (this IQueryable<T> query, int pageNumber, int pageSize)
    {
        pageNumber++;

        return query
            .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize);
    }
}