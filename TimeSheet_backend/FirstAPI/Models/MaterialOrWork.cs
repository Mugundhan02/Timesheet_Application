using System.ComponentModel.DataAnnotations;

namespace FirstAPI.Models
{
    public class MaterialOrWork
    {
        [Key]
        public int MaterialOrWorkId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        // "Material" or "Work" or "Job"
        [MaxLength(20)]
        public string Category { get; set; } = "Material";

        [MaxLength(30)]
        public string? DefaultUnit { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
