using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstAPI.Models
{
    public class SubContractorTransaction
    {
        [Key]
        public int SubContractorTransactionId { get; set; }

        [Required]
        public DateTime TxnDate { get; set; }

        [Required]
        public int ClientId { get; set; }

        [Required]
        public int SubContractorId { get; set; }

        public int? MaterialOrWorkId { get; set; }

        [MaxLength(100)]
        public string? JobWorkName { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Quantity { get; set; } = 0;

        [MaxLength(30)]
        public string? Unit { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Rate { get; set; } = 0;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; } = 0;

        [Column(TypeName = "decimal(18,2)")]
        public decimal PaidAmount { get; set; } = 0;

        [MaxLength(50)]
        public string? PaymentType { get; set; }

        [MaxLength(100)]
        public string? ToWhom { get; set; }

        [MaxLength(500)]
        public string? Remarks { get; set; }

        // SubBill reference
        public int? SubBillId { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation
        [ForeignKey("ClientId")]
        public Client? Client { get; set; }

        [ForeignKey("SubContractorId")]
        public SubContractor? SubContractor { get; set; }

        [ForeignKey("MaterialOrWorkId")]
        public MaterialOrWork? MaterialOrWork { get; set; }
    }
}
