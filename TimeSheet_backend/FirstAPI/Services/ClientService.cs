using FirstAPI.Exceptions;
using FirstAPI.Interfaces;
using FirstAPI.Models;
using FirstAPI.Models.DTOs;
using Microsoft.EntityFrameworkCore;

namespace FirstAPI.Services
{
    public class ClientService : IClientService
    {
        private readonly IRepository<int, Client> _clientRepo;
        private readonly IRepository<int, ClientTransaction> _clientTxnRepo;
        private readonly IRepository<int, SupplierTransaction> _supplierTxnRepo;
        private readonly IRepository<int, SubContractorTransaction> _subConTxnRepo;

        public ClientService(
            IRepository<int, Client> clientRepo,
            IRepository<int, ClientTransaction> clientTxnRepo,
            IRepository<int, SupplierTransaction> supplierTxnRepo,
            IRepository<int, SubContractorTransaction> subConTxnRepo)
        {
            _clientRepo = clientRepo;
            _clientTxnRepo = clientTxnRepo;
            _supplierTxnRepo = supplierTxnRepo;
            _subConTxnRepo = subConTxnRepo;
        }

        public async Task<ClientResponseDto> CreateClientAsync(ClientCreateDto dto)
        {
            // Check for duplicate name
            var existing = (await _clientRepo.GetQueryable()
                .Where(c => c.ClientName.ToLower() == dto.ClientName.ToLower())
                .ToListAsync());
            if (existing.Any())
                throw new InvalidOperationException($"Client '{dto.ClientName}' already exists.");

            var client = new Client
            {
                ClientName = dto.ClientName,
                Phone = dto.Phone,
                Address = dto.Address
            };

            await _clientRepo.Add(client);
            return await MapToResponseDto(client);
        }

        public async Task<ClientResponseDto> GetClientByIdAsync(int clientId)
        {
            var client = await _clientRepo.Get(clientId);
            return await MapToResponseDto(client);
        }

        public async Task<IEnumerable<ClientResponseDto>> GetAllClientsAsync()
        {
            var clients = await _clientRepo.GetQueryable()
                .OrderBy(c => c.ClientName)
                .ToListAsync();
            var result = new List<ClientResponseDto>();
            foreach (var c in clients)
                result.Add(await MapToResponseDto(c));
            return result;
        }

        public async Task<ClientResponseDto> UpdateClientAsync(int clientId, ClientUpdateDto dto)
        {
            var client = await _clientRepo.Get(clientId);
            if (dto.ClientName != null) client.ClientName = dto.ClientName;
            if (dto.Phone != null) client.Phone = dto.Phone;
            if (dto.Address != null) client.Address = dto.Address;
            if (dto.IsActive.HasValue) client.IsActive = dto.IsActive.Value;
            await _clientRepo.Update(client);
            return await MapToResponseDto(client);
        }

        public async Task DeleteClientAsync(int clientId)
        {
            await _clientRepo.Delete(clientId);
        }

        public async Task<ClientSummaryDto> GetClientSummaryAsync(int clientId)
        {
            var client = await _clientRepo.Get(clientId);

            var clientTxns = await _clientTxnRepo.GetQueryable()
                .Where(t => t.ClientId == clientId)
                .ToListAsync();

            var supplierTxns = await _supplierTxnRepo.GetQueryable()
                .Where(t => t.ClientId == clientId)
                .ToListAsync();

            var subConTxns = await _subConTxnRepo.GetQueryable()
                .Where(t => t.ClientId == clientId)
                .ToListAsync();

            var totalCredits = clientTxns.Sum(t => t.CreditAmount);
            var totalDebits = clientTxns.Sum(t => t.DebitAmount);
            var supplierPayable = supplierTxns.Sum(t => t.Amount);
            var supplierPaid = supplierTxns.Sum(t => t.PaidAmount);
            var subConPayable = subConTxns.Sum(t => t.Amount);
            var subConPaid = subConTxns.Sum(t => t.PaidAmount);

            return new ClientSummaryDto
            {
                ClientId = client.ClientId,
                ClientName = client.ClientName,
                TotalCredits = totalCredits,
                TotalDebits = totalDebits,
                Balance = totalCredits - totalDebits,
                EstimatedUnits = 0,
                EstimatedRate = 0,
                EstimatedAmount = 0,
                EstAmtReceived = totalCredits,
                EstAmtExpenses = supplierPayable + subConPayable,
                SupplierPayable = supplierPayable,
                SupplierPaid = supplierPaid,
                SupplierBalance = supplierPayable - supplierPaid,
                SubContractorPayable = subConPayable,
                SubContractorPaid = subConPaid,
                SubContractorBalance = subConPayable - subConPaid
            };
        }

        private async Task<ClientResponseDto> MapToResponseDto(Client client)
        {
            var txns = await _clientTxnRepo.GetQueryable()
                .Where(t => t.ClientId == client.ClientId)
                .ToListAsync();
            var totalCredits = txns.Sum(t => t.CreditAmount);
            var totalDebits = txns.Sum(t => t.DebitAmount);
            return new ClientResponseDto
            {
                ClientId = client.ClientId,
                ClientName = client.ClientName,
                Phone = client.Phone,
                Address = client.Address,
                IsActive = client.IsActive,
                CreatedAt = client.CreatedAt,
                TotalCredits = totalCredits,
                TotalDebits = totalDebits,
                Balance = totalCredits - totalDebits
            };
        }
    }
}
