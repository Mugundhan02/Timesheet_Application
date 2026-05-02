using FirstAPI.Models.DTOs;

namespace FirstAPI.Interfaces
{
    public interface ICompanyExpenseTransactionService
    {
        Task<CompanyExpenseTransactionResponseDto> CreateAsync(CompanyExpenseTransactionCreateDto dto);
        Task<CompanyExpenseTransactionResponseDto> GetByIdAsync(int id);
        Task<IEnumerable<CompanyExpenseTransactionResponseDto>> GetAllAsync(CompanyExpenseTransactionFilterDto filter);
        Task<CompanyExpenseTransactionResponseDto> UpdateAsync(int id, CompanyExpenseTransactionUpdateDto dto);
        Task DeleteAsync(int id);
        Task<CompanySummaryDto> GetCompanySummaryAsync(string companyName);
    }
}
