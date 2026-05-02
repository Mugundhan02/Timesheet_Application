using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstAPI.Models
{
    public class SupplierTransaction
    {
        [Key]
        public int SupplierTransactionId { get; set; }

        [Required]
        public DateTime TxnDate { get; set; }

        [Required]
        public int ClientId { get; set; }

        [Required]
        public int SupplierId { get; set; }

        public int? MaterialOrWorkId { get; set; }

        [MaxLength(100)]
        public string? MaterialName { get; set; }

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

        // SubBill reference (grouping multiple lines into one bill)
        public int? SubBillId { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation
        [ForeignKey("ClientId")]
        public Client? Client { get; set; }

        [ForeignKey("SupplierId")]
        public Supplier? Supplier { get; set; }

        [ForeignKey("MaterialOrWorkId")]
        public MaterialOrWork? MaterialOrWork { get; set; }
    }
}
