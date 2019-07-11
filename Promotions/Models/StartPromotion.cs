using System;
using System.ComponentModel.DataAnnotations;

namespace Promotions.Models
{
    public class StartPromotion
    {
        public StartPromotion()
        {
        }

        [StringLength(50)]
        [Required(ErrorMessage = "Required field.")]
        [RegularExpression(@"^[A-Z a-z0-9ÑñáéíóúÁÉÍÓÚ\\-\\_]+$",
            ErrorMessage = "The Customer must be alphanumeric.")]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Required field.")]
        [RegularExpression(@"^\d+$",
            ErrorMessage = "The Number of prizes must be numeric.")]
        [Display(Name = "Number of Prizes")]
        public int NumberPrizes { get; set; }

        [Required(ErrorMessage = "Required field.")]
        [RegularExpression(@"^-?[0-9][0-9,\.]+$",
            ErrorMessage = "The Total prizes must be decimal.")]
        [Display(Name = "Total Prize")]
        public decimal TotalPrize { get; set; }
    }
}
