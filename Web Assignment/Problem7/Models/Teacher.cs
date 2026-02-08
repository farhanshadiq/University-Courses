using System.ComponentModel.DataAnnotations;

namespace Problem7.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        public string? Subject { get; set; }

        [Required]
        public string? Department { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Salary { get; set; }

        public DateTime JoinDate { get; set; }

        [Required]
        public string? PhoneNumber { get; set; }
    }
}
