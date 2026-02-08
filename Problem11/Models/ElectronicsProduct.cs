using System.ComponentModel.DataAnnotations;

namespace Problem11.Models
{
    public class ElectronicsProduct
    {
        public int Id { get; set; }

        [Required]
        public string? ProductName { get; set; }

        [Required]
        public string? Brand { get; set; }

        [Required]
        public string? Model { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        [Required]
        public string? Category { get; set; }

        [Required]
        public string? WarrantyPeriod { get; set; }

        [Range(0, int.MaxValue)]
        public int StockQuantity { get; set; }

        [Required]
        public string? Description { get; set; }
    }
}
