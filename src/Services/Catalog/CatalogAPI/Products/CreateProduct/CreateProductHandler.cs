using BuildingBlocks.CQRS;
using CatalogAPI.Models;
using MediatR;
using System.Windows.Input;

namespace CatalogAPI.Products.CreateProduct
{
    public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal Price)
        :ICommand<CreateProdcutResult>;
    public record CreateProdcutResult(Guid Id);
    internal class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, CreateProdcutResult>
    {
        public async Task<CreateProdcutResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            // create
            // save to db
            // return CreateProdcutResult result

            // create
            var product = new Product
            {
                Name = command.Name,
                Category = command.Category,
                Description = command.Description,
                ImageFile = command.ImageFile,
                Price = command.Price
            };

            //TODO
            // save to db

            // return CreateProdcutResult result
            return new CreateProdcutResult(Guid.NewGuid());
            
        }
    

    }
}
