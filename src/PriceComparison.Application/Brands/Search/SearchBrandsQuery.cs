using MediatR;
using PriceComparison.Application.Abstractions;

namespace PriceComparison.Application.Brands.Search;

public record SearchBrandsQuery(string Search, int Page = 1, int PageSize = 20) : IRequest<IPagedList<BrandResponse>>;