namespace FirstAPI.Models.DTOs
{
    // ──── MaterialOrWork DTOs ────
    public class MaterialOrWorkCreateDto
    {
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = "Material";
        public string? DefaultUnit { get; set; }
    }

    public class MaterialOrWorkUpdateDto
    {
        public string? Name { get; set; }
        public string? Category { get; set; }
        public string? DefaultUnit { get; set; }
        public bool? IsActive { get; set; }
    }

    public class MaterialOrWorkResponseDto
    {
        public int MaterialOrWorkId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string? DefaultUnit { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    // ──── ExpenseName DTOs ────
    public class ExpenseNameCreateDto
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
    }

    public class ExpenseNameUpdateDto
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
    }

    public class ExpenseNameResponseDto
    {
        public int ExpenseNameId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
