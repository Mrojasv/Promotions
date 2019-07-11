using System;
using System.ComponentModel.DataAnnotations;

namespace Promotions.Models
{
    public class PromotionViewModel
    {
        public PromotionViewModel()
        {
        }

        [StringLength(50)]
        [Required(ErrorMessage = "Required field.")]
        [RegularExpression(@"^[A-Z a-z0-9ÑñáéíóúÁÉÍÓÚ\\-\\_]+$",
            ErrorMessage = "The Name must be alphanumeric.")]
        [Display(Name = "Name")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Required field.")]
        [RegularExpression(@"^-?[0-9][0-9,\.]+$",
            ErrorMessage = "The Claimed Amount must be decimal.")]
        [Display(Name = "Claimed Amount")]
        public Decimal ClaimedAmount { get; set; }
    }
}
