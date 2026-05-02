using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstAPI.Models
{
    public class ClientTransaction
    {
        [Key]
        public int ClientTransactionId { get; set; }

        [Required]
        public DateTime TxnDate { get; set; }

        [Required]
        public int ClientId { get; set; }

        // Credit (received from client)
        [Column(TypeName = "decimal(18,2)")]
        public decimal CreditAmount { get; set; } = 0;

        // Debit (paid to client)
        [Column(TypeName = "decimal(18,2)")]
        public decimal DebitAmount { get; set; } = 0;

        [MaxLength(50)]
        public string? PaymentType { get; set; }

        [MaxLength(100)]
        public string? ByWhom { get; set; }

        [MaxLength(500)]
        public string? Remarks { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation
        [ForeignKey("ClientId")]
        public Client? Client { get; set; }
    }
}
