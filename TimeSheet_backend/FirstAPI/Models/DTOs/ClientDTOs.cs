namespace FirstAPI.Models.DTOs
{
    // ──── Client DTOs ────
    public class ClientCreateDto
    {
        public string ClientName { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public string? Address { get; set; }
    }

    public class ClientUpdateDto
    {
        public string? ClientName { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public bool? IsActive { get; set; }
    }

    public class ClientResponseDto
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        // Computed balances
        public decimal TotalCredits { get; set; }
        public decimal TotalDebits { get; set; }
        public decimal Balance { get; set; }
    }

    public class ClientSummaryDto
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; } = string.Empty;
        public decimal TotalCredits { get; set; }
        public decimal TotalDebits { get; set; }
        public decimal Balance { get; set; }
        // Estimated project values
        public decimal EstimatedUnits { get; set; }
        public decimal EstimatedRate { get; set; }
        public decimal EstimatedAmount { get; set; }
        public decimal EstAmtReceived { get; set; }
        public decimal EstAmtExpenses { get; set; }

        // Supplier totals
        public decimal SupplierPayable { get; set; }
        public decimal SupplierPaid { get; set; }
        public decimal SupplierBalance { get; set; }

        // SubContractor totals
        public decimal SubContractorPayable { get; set; }
        public decimal SubContractorPaid { get; set; }
        public decimal SubContractorBalance { get; set; }
    }
}
