using FirstAPI.Models;
using FirstAPI.Models.DTOs;

namespace FirstAPI.Interfaces
{
    public interface IClientService
    {
        Task<ClientResponseDto> CreateClientAsync(ClientCreateDto dto);
        Task<ClientResponseDto> GetClientByIdAsync(int clientId);
        Task<IEnumerable<ClientResponseDto>> GetAllClientsAsync();
        Task<ClientResponseDto> UpdateClientAsync(int clientId, ClientUpdateDto dto);
        Task DeleteClientAsync(int clientId);
        Task<ClientSummaryDto> GetClientSummaryAsync(int clientId);
    }
}
