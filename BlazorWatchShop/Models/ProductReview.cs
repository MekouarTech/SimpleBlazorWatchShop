using System.ComponentModel.DataAnnotations;

namespace BlazorWatchShop.Models
{
    public class ProductReview
    {
        [Required]
        public string ReviewerName { get; set; }
        
        [Required]
        [EmailAddress]
        public string ReviewerEmail { get; set; }
        
        [Required]
        public string Rate { get; set; }

        [StringLength(350)]
        public string Comment { get; set; }
    }
}
