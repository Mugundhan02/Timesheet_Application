using FirstAPI.Models;
using FirstAPI.Models.DTOs;

namespace FirstAPI.Interfaces
{
    public interface ISupplierService
    {
        Task<SupplierResponseDto> CreateSupplierAsync(SupplierCreateDto dto);
        Task<SupplierResponseDto> GetSupplierByIdAsync(int supplierId);
        Task<IEnumerable<SupplierResponseDto>> GetAllSuppliersAsync();
        Task<SupplierResponseDto> UpdateSupplierAsync(int supplierId, SupplierUpdateDto dto);
        Task DeleteSupplierAsync(int supplierId);
        Task<IEnumerable<SupplierSummaryDto>> GetSupplierSummaryByClientAsync(int clientId);
    }
}
