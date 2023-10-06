using MediatR;
using PriceComparison.Domain.Common.ValueObjects;

namespace PriceComparison.Application.Brands.Create;

public record CreateBrandCommand(string Name, Slug Slug) : IRequest;