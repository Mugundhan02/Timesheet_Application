using FirstAPI.Models.DTOs;

namespace FirstAPI.Interfaces
{
    public interface IExpenseNameService
    {
        Task<ExpenseNameResponseDto> CreateAsync(ExpenseNameCreateDto dto);
        Task<ExpenseNameResponseDto> GetByIdAsync(int id);
        Task<IEnumerable<ExpenseNameResponseDto>> GetAllAsync();
        Task<ExpenseNameResponseDto> UpdateAsync(int id, ExpenseNameUpdateDto dto);
        Task DeleteAsync(int id);
    }
}
