using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ZombieParty.Models
{
    public class HuntingLog
    {
        public int Id { get; set; }

        [Display(Name = "Title")]
        [Required(ErrorMessage = "ValidationRequired")]
        [StringLength(25, MinimumLength = 5, ErrorMessage = "ValidationStringMinMax")]
        public string Title { get; set; }

        [StringLength(255, ErrorMessage = "ValidationStringMax")]
        [Required(ErrorMessage = "ValidationRequired")]
        [Display(Name = "Description")]
        public string Description { get; set; }
        public DateTime AdventureDate { get; set; }

        [Display(Name = "Zombies")]
        [ValidateNever]
        public virtual List<Zombie> Zombies { get; set; }
    }
}
