using FirstAPI.Models.DTOs;

namespace FirstAPI.Interfaces
{
    public interface ISubContractorTransactionService
    {
        Task<SubContractorTransactionResponseDto> CreateAsync(SubContractorTransactionCreateDto dto);
        Task<SubContractorTransactionResponseDto> GetByIdAsync(int id);
        Task<IEnumerable<SubContractorTransactionResponseDto>> GetAllAsync(SubContractorTransactionFilterDto filter);
        Task<SubContractorTransactionResponseDto> UpdateAsync(int id, SubContractorTransactionUpdateDto dto);
        Task DeleteAsync(int id);
        Task<SubContractorTransactionTotalsDto> GetTotalsAsync(SubContractorTransactionFilterDto filter);
    }
}
