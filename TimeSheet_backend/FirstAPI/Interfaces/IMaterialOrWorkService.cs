using FirstAPI.Models.DTOs;

namespace FirstAPI.Interfaces
{
    public interface IMaterialOrWorkService
    {
        Task<MaterialOrWorkResponseDto> CreateAsync(MaterialOrWorkCreateDto dto);
        Task<MaterialOrWorkResponseDto> GetByIdAsync(int id);
        Task<IEnumerable<MaterialOrWorkResponseDto>> GetAllAsync(string? category = null);
        Task<MaterialOrWorkResponseDto> UpdateAsync(int id, MaterialOrWorkUpdateDto dto);
        Task DeleteAsync(int id);
    }
}
