using FirstAPI.Models.DTOs;

namespace FirstAPI.Interfaces
{
    public interface IClientTransactionService
    {
        Task<ClientTransactionResponseDto> CreateAsync(ClientTransactionCreateDto dto);
        Task<ClientTransactionResponseDto> GetByIdAsync(int id);
        Task<IEnumerable<ClientTransactionResponseDto>> GetAllAsync(ClientTransactionFilterDto filter);
        Task<ClientTransactionResponseDto> UpdateAsync(int id, ClientTransactionUpdateDto dto);
        Task DeleteAsync(int id);
    }
}
