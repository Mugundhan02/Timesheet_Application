namespace FirstAPI.Models.DTOs
{
    // ──── ClientTransaction DTOs ────
    public class ClientTransactionCreateDto
    {
        public DateTime TxnDate { get; set; }
        public int ClientId { get; set; }
        public decimal CreditAmount { get; set; } = 0;
        public decimal DebitAmount { get; set; } = 0;
        public string? PaymentType { get; set; }
        public string? ByWhom { get; set; }
        public string? Remarks { get; set; }
    }

    public class ClientTransactionUpdateDto
    {
        public DateTime? TxnDate { get; set; }
        public decimal? CreditAmount { get; set; }
        public decimal? DebitAmount { get; set; }
        public string? PaymentType { get; set; }
        public string? ByWhom { get; set; }
        public string? Remarks { get; set; }
    }

    public class ClientTransactionResponseDto
    {
        public int ClientTransactionId { get; set; }
        public DateTime TxnDate { get; set; }
        public int ClientId { get; set; }
        public string ClientName { get; set; } = string.Empty;
        public decimal CreditAmount { get; set; }
        public decimal DebitAmount { get; set; }
        public string? PaymentType { get; set; }
        public string? ByWhom { get; set; }
        public string? Remarks { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class ClientTransactionFilterDto
    {
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? ClientId { get; set; }
        public string? PaymentType { get; set; }
    }
}
