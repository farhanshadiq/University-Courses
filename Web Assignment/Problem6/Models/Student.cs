using System.ComponentModel.DataAnnotations;

namespace Problem6.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        public string? RollNumber { get; set; }

        [Required]
        public string? Semester { get; set; }

        [Required]
        public string? Department { get; set; }

        [Range(0, 100)]
        public decimal CGPA { get; set; }

        public DateTime EnrollmentDate { get; set; }
    }
}
