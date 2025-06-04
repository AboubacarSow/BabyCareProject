using BabyCareProject.Dtos.InstructorDtos;

namespace BabyCareProject.Services.Contracts;

public interface IInstructorService
{
    Task<List<ResultInstructorDto>> GetAllAsync();
    Task<UpdateInstructorDto> GetByIdAsync(string id);
    Task CreateAsync(CreateInstructorDto instructorDto);
    Task UpdateAsync(UpdateInstructorDto instructorDto);
    Task DeleteAsync(string id);
}
