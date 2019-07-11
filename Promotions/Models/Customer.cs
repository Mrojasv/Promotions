using System;
using System.ComponentModel.DataAnnotations;

namespace Promotions.Models
{
    public class Customer
    {
        public Customer()
        {
        }

        [StringLength(50)]
        [Required(ErrorMessage = "Required field.")]
        [RegularExpression(@"^[A-Z a-z0-9ÑñáéíóúÁÉÍÓÚ\\-\\_]+$",
            ErrorMessage = "The Name must be alphanumeric.")]
        [Display(Name = "Name")]
        public String Name { get; set; }
    }
}
