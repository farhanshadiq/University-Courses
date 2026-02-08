using System.ComponentModel.DataAnnotations;

namespace Problem5.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        public string? JobTitle { get; set; }

        [Required]
        public string? Department { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Salary { get; set; }

        public DateTime HireDate { get; set; }

        [Required]
        public string? PhoneNumber { get; set; }
    }
}
