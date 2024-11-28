namespace FastPaginate;

public abstract class PaginateRequest
{
    public required int PageNumber { get; init; }
    public required int PageSize { get; init; }
}