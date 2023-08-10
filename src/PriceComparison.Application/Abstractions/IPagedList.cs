namespace PriceComparison.Application.Abstractions;

public interface IPagedList<T>
{
    public List<T> Items { get; }

    public int Page { get; }
    
    public int PageSize { get; }
    
    public int TotalCount { get; }
}