namespace FastPaginate;

public class PaginatedList<T>
{
    public required int TotalCount { get; init; }
    public required List<T> Values { get; init; }
}
