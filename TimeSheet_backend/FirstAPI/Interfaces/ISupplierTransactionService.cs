using FirstAPI.Models.DTOs;

namespace FirstAPI.Interfaces
{
    public interface ISupplierTransactionService
    {
        Task<SupplierTransactionResponseDto> CreateAsync(SupplierTransactionCreateDto dto);
        Task<SupplierTransactionResponseDto> GetByIdAsync(int id);
        Task<IEnumerable<SupplierTransactionResponseDto>> GetAllAsync(SupplierTransactionFilterDto filter);
        Task<SupplierTransactionResponseDto> UpdateAsync(int id, SupplierTransactionUpdateDto dto);
        Task DeleteAsync(int id);
        Task<SupplierTransactionTotalsDto> GetTotalsAsync(SupplierTransactionFilterDto filter);
    }
}
