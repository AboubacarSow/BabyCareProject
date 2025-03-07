using BabyCareProject.Dtos.InstructorDtos;
using BabyCareProject.Dtos.ProductDtos;

namespace BabyCareProject.Services.Contracts
{
    public interface IProductService
    {
        Task<List<ResultProductDto>> GetAllAsync();
        Task<UpdateProductDto> GetByIdAsync(string id);
        Task CreateAsync(CreateProdutDto productDto);
        Task UpdateAsync(UpdateProductDto productDto);
        Task DeleteAsync(string id);
    }
}
