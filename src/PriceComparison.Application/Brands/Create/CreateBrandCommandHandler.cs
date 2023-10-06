using MediatR;
using PriceComparison.Application.Abstractions;
using PriceComparison.Domain.Brands;

namespace PriceComparison.Application.Brands.Create;

public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand>
{
    private readonly IBrandRepository _brandRepository;

    public CreateBrandCommandHandler(IBrandRepository brandRepository)
    {
        _brandRepository = brandRepository;
    }
    
    public Task Handle(CreateBrandCommand request, CancellationToken cancellationToken)
    {
        var brand = Brand.Create(
            request.Name,
            request.Slug
        );
        
        _brandRepository.Add(brand);
        
        return Task.CompletedTask;
    }
}