using System.ComponentModel.DataAnnotations;

namespace FirstAPI.Models
{
    public class ExpenseName
    {
        [Key]
        public int ExpenseNameId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(200)]
        public string? Description { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation
        public ICollection<CompanyExpenseTransaction> CompanyExpenseTransactions { get; set; } = new List<CompanyExpenseTransaction>();
    }
}
