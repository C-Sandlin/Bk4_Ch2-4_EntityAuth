using System.ComponentModel.DataAnnotations;

namespace AuthPractice.Models
{
    public class Product
    {

        [Required]
        public int Id { get; set; }
    }
}