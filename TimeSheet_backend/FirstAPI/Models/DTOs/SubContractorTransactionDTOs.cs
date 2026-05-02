namespace FirstAPI.Models.DTOs
{
    // ──── SubContractorTransaction DTOs ────
    public class SubContractorTransactionCreateDto
    {
        public DateTime TxnDate { get; set; }
        public int ClientId { get; set; }
        public int SubContractorId { get; set; }
        public int? MaterialOrWorkId { get; set; }
        public string? JobWorkName { get; set; }
        public decimal Quantity { get; set; } = 0;
        public string? Unit { get; set; }
        public decimal Rate { get; set; } = 0;
        public decimal Amount { get; set; } = 0;
        public decimal PaidAmount { get; set; } = 0;
        public string? PaymentType { get; set; }
        public string? ToWhom { get; set; }
        public string? Remarks { get; set; }
        public int? SubBillId { get; set; }
    }

    public class SubContractorTransactionUpdateDto
    {
        public DateTime? TxnDate { get; set; }
        public int? MaterialOrWorkId { get; set; }
        public string? JobWorkName { get; set; }
        public decimal? Quantity { get; set; }
        public string? Unit { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Amount { get; set; }
        public decimal? PaidAmount { get; set; }
        public string? PaymentType { get; set; }
        public string? ToWhom { get; set; }
        public string? Remarks { get; set; }
    }

    public class SubContractorTransactionResponseDto
    {
        public int SubContractorTransactionId { get; set; }
        public DateTime TxnDate { get; set; }
        public int ClientId { get; set; }
        public string ClientName { get; set; } = string.Empty;
        public int SubContractorId { get; set; }
        public string SubContractorName { get; set; } = string.Empty;
        public int? MaterialOrWorkId { get; set; }
        public string? JobWorkName { get; set; }
        public decimal Quantity { get; set; }
        public string? Unit { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
        public decimal PaidAmount { get; set; }
        public string? PaymentType { get; set; }
        public string? ToWhom { get; set; }
        public string? Remarks { get; set; }
        public int? SubBillId { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class SubContractorTransactionFilterDto
    {
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? ClientId { get; set; }
        public int? SubContractorId { get; set; }
        public string? PaymentType { get; set; }
    }

    public class SubContractorTransactionTotalsDto
    {
        public decimal TotalPayable { get; set; }
        public decimal TotalPaid { get; set; }
        public decimal TotalBalance { get; set; }
    }
}
