namespace FirstAPI.Models.DTOs
{
    // ──── SubContractor DTOs ────
    public class SubContractorCreateDto
    {
        public string SubContractorName { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public string? Address { get; set; }
    }

    public class SubContractorUpdateDto
    {
        public string? SubContractorName { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public bool? IsActive { get; set; }
    }

    public class SubContractorResponseDto
    {
        public int SubContractorId { get; set; }
        public string SubContractorName { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class SubContractorSummaryDto
    {
        public int SubContractorId { get; set; }
        public string SubContractorName { get; set; } = string.Empty;
        public decimal PayableAmount { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal BalanceAmount { get; set; }
    }
}
