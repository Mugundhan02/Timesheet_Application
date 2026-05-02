namespace FirstAPI.Models.DTOs
{
    // ──── CompanyExpenseTransaction DTOs ────
    public class CompanyExpenseTransactionCreateDto
    {
        public DateTime TxnDate { get; set; }
        public string? CompanyName { get; set; }
        public int? ClientId { get; set; }
        public int? ExpenseNameId { get; set; }
        public int? MaterialOrWorkId { get; set; }
        public decimal Amount { get; set; } = 0;
        public decimal ReceivedAmount { get; set; } = 0;
        public decimal PaidAmount { get; set; } = 0;
        public string? PaymentType { get; set; }
        public string? ToWhom { get; set; }
        public string? Remarks { get; set; }
    }

    public class CompanyExpenseTransactionUpdateDto
    {
        public DateTime? TxnDate { get; set; }
        public int? ClientId { get; set; }
        public int? ExpenseNameId { get; set; }
        public int? MaterialOrWorkId { get; set; }
        public decimal? Amount { get; set; }
        public decimal? ReceivedAmount { get; set; }
        public decimal? PaidAmount { get; set; }
        public string? PaymentType { get; set; }
        public string? ToWhom { get; set; }
        public string? Remarks { get; set; }
    }

    public class CompanyExpenseTransactionResponseDto
    {
        public int CompanyExpenseTransactionId { get; set; }
        public DateTime TxnDate { get; set; }
        public string? CompanyName { get; set; }
        public int? ClientId { get; set; }
        public string? ClientName { get; set; }
        public int? ExpenseNameId { get; set; }
        public string? ExpenseNameValue { get; set; }
        public int? MaterialOrWorkId { get; set; }
        public string? MaterialOrWorkName { get; set; }
        public decimal Amount { get; set; }
        public decimal ReceivedAmount { get; set; }
        public decimal PaidAmount { get; set; }
        public string? PaymentType { get; set; }
        public string? ToWhom { get; set; }
        public string? Remarks { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class CompanyExpenseTransactionFilterDto
    {
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? ClientId { get; set; }
        public int? ExpenseNameId { get; set; }
        public string? PaymentType { get; set; }
    }

    public class CompanySummaryDto
    {
        public string CompanyName { get; set; } = string.Empty;
        public decimal TotalCredits { get; set; }
        public decimal TotalDebits { get; set; }
        public decimal Balance { get; set; }
    }
}
