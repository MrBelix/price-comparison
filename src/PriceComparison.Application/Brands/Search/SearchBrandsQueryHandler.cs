using MediatR;
using PriceComparison.Application.Abstractions;

namespace PriceComparison.Application.Brands.Search;

public class SearchBrandsQueryHandler : IRequestHandler<SearchBrandsQuery, IPagedList<BrandResponse>>
{
    private readonly IBrandReadService _brandReadService;

    public SearchBrandsQueryHandler(IBrandReadService brandReadService)
    {
        _brandReadService = brandReadService;
    }
    
    public Task<IPagedList<BrandResponse>> Handle(SearchBrandsQuery request, CancellationToken cancellationToken)
    {
        return _brandReadService.SearchAsync(request.Search, request.Page, request.PageSize);
    }
}