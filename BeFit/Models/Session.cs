using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BeFit.Models
{
    public class Session
    {
        public int Id { get; set; }
        [Display(Name = "Data rozpoczęcia")]
        [Required]
        public DateTime Start {  get; set; }
        [Display(Name = "Data zakończenia")]
        [Required]
        public DateTime End { get; set; }
        public string? UserId { get; set; }
        [Display(Name = "Użytkownik")]
        public IdentityUser? User { get; set; }
    }
}
