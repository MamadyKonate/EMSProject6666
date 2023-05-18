using System.ComponentModel.DataAnnotations;

namespace EMSProject6.Models
{
    public class LeaveType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = default;
    }
}
