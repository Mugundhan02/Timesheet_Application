namespace FirstAPI.Models.DTOs
{
    // ──── SupplierTransaction DTOs ────
    public class SupplierTransactionCreateDto
    {
        public DateTime TxnDate { get; set; }
        public int ClientId { get; set; }
        public int SupplierId { get; set; }
        public int? MaterialOrWorkId { get; set; }
        public string? MaterialName { get; set; }
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

    public class SupplierTransactionUpdateDto
    {
        public DateTime? TxnDate { get; set; }
        public int? MaterialOrWorkId { get; set; }
        public string? MaterialName { get; set; }
        public decimal? Quantity { get; set; }
        public string? Unit { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Amount { get; set; }
        public decimal? PaidAmount { get; set; }
        public string? PaymentType { get; set; }
        public string? ToWhom { get; set; }
        public string? Remarks { get; set; }
    }

    public class SupplierTransactionResponseDto
    {
        public int SupplierTransactionId { get; set; }
        public DateTime TxnDate { get; set; }
        public int ClientId { get; set; }
        public string ClientName { get; set; } = string.Empty;
        public int SupplierId { get; set; }
        public string SupplierName { get; set; } = string.Empty;
        public int? MaterialOrWorkId { get; set; }
        public string? MaterialName { get; set; }
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

    public class SupplierTransactionFilterDto
    {
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? ClientId { get; set; }
        public int? SupplierId { get; set; }
        public string? PaymentType { get; set; }
    }

    public class SupplierTransactionTotalsDto
    {
        public decimal TotalPayable { get; set; }
        public decimal TotalPaid { get; set; }
        public decimal TotalBalance { get; set; }
    }
}
