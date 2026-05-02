using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstAPI.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }

        [Required]
        [MaxLength(100)]
        public string ClientName { get; set; } = string.Empty;

        [MaxLength(15)]
        public string? Phone { get; set; }

        [MaxLength(200)]
        public string? Address { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation
        public ICollection<ClientTransaction> ClientTransactions { get; set; } = new List<ClientTransaction>();
        public ICollection<SupplierTransaction> SupplierTransactions { get; set; } = new List<SupplierTransaction>();
        public ICollection<SubContractorTransaction> SubContractorTransactions { get; set; } = new List<SubContractorTransaction>();
        public ICollection<CompanyExpenseTransaction> CompanyExpenseTransactions { get; set; } = new List<CompanyExpenseTransaction>();
    }
}
