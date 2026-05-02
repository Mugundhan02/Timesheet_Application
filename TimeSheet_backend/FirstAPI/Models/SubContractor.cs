using System.ComponentModel.DataAnnotations;

namespace FirstAPI.Models
{
    public class SubContractor
    {
        [Key]
        public int SubContractorId { get; set; }

        [Required]
        [MaxLength(100)]
        public string SubContractorName { get; set; } = string.Empty;

        [MaxLength(15)]
        public string? Phone { get; set; }

        [MaxLength(200)]
        public string? Address { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation
        public ICollection<SubContractorTransaction> SubContractorTransactions { get; set; } = new List<SubContractorTransaction>();
    }
}
