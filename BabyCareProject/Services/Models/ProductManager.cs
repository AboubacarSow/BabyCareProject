using AutoMapper;
using BabyCareProject.Dtos.ProductDtos;
using BabyCareProject.Infrastructure.Utilities;
using BabyCareProject.Repositories.Entities;
using BabyCareProject.Repositories.Settings;
using BabyCareProject.Services.Contracts;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace BabyCareProject.Services.Models
{
    public class ProductManager : IProductService
    {
        private readonly IMongoCollection<Product> _productCollection;
        private readonly IMapper _mapper;

        public ProductManager(IMapper mapper, IDataBaseSettings dataBaseSettings)
        {
            _mapper = mapper;
            var client = new MongoClient(dataBaseSettings.ConnectionStrings);
            var database = client.GetDatabase(dataBaseSettings.DataBaseName);
            _productCollection = database.GetCollection<Product>(dataBaseSettings.ProductCollectionName);
        }
        public async Task CreateAsync(CreateProdutDto productDto)
        {
            productDto.ImageUrl = await Media.UploadAsync(productDto.ImageFile);
            var product = _mapper.Map<Product>(productDto);
            await _productCollection.InsertOneAsync(product);
        }

        public async Task DeleteAsync(string id)
        {
            await _productCollection.DeleteOneAsync(product=>product.Id==id);
        }

        public async Task<List<ResultProductDto>> GetAllAsync()
        {
            var products = await _productCollection.AsQueryable().ToListAsync();
            return _mapper.Map<List<ResultProductDto>>(products);
        }

        public async Task<UpdateProductDto> GetByIdAsync(string id)
        {
            var product = await _productCollection.Find(i => i.Id == id).FirstOrDefaultAsync();
            return _mapper.Map<UpdateProductDto>(product);
        }

        public async Task UpdateAsync(UpdateProductDto productDto)
        {
            productDto.ImageUrl =await Media.UploadAsync(productDto.ImageFile);
            var product = _mapper.Map<Product>(productDto);
            await _productCollection.FindOneAndReplaceAsync(p=>p.Id==product.Id,product);
        }
    }
}
