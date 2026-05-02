using FirstAPI.Models;
using FirstAPI.Models.DTOs;

namespace FirstAPI.Interfaces
{
    public interface ISubContractorService
    {
        Task<SubContractorResponseDto> CreateSubContractorAsync(SubContractorCreateDto dto);
        Task<SubContractorResponseDto> GetSubContractorByIdAsync(int subContractorId);
        Task<IEnumerable<SubContractorResponseDto>> GetAllSubContractorsAsync();
        Task<SubContractorResponseDto> UpdateSubContractorAsync(int subContractorId, SubContractorUpdateDto dto);
        Task DeleteSubContractorAsync(int subContractorId);
        Task<IEnumerable<SubContractorSummaryDto>> GetSubContractorSummaryByClientAsync(int clientId);
    }
}
