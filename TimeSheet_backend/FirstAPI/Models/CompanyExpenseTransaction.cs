using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstAPI.Models
{
    public class CompanyExpenseTransaction
    {
        [Key]
        public int CompanyExpenseTransactionId { get; set; }

        [Required]
        public DateTime TxnDate { get; set; }

        // Company name (from appsettings/config – single company app)
        [MaxLength(100)]
        public string? CompanyName { get; set; }

        public int? ClientId { get; set; }

        public int? ExpenseNameId { get; set; }

        public int? MaterialOrWorkId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; } = 0;

        [Column(TypeName = "decimal(18,2)")]
        public decimal ReceivedAmount { get; set; } = 0;

        [Column(TypeName = "decimal(18,2)")]
        public decimal PaidAmount { get; set; } = 0;

        [MaxLength(50)]
        public string? PaymentType { get; set; }

        [MaxLength(100)]
        public string? ToWhom { get; set; }

        [MaxLength(500)]
        public string? Remarks { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation
        [ForeignKey("ClientId")]
        public Client? Client { get; set; }

        [ForeignKey("ExpenseNameId")]
        public ExpenseName? ExpenseName { get; set; }

        [ForeignKey("MaterialOrWorkId")]
        public MaterialOrWork? MaterialOrWork { get; set; }
    }
}
