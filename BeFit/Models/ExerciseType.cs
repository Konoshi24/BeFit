using System.ComponentModel.DataAnnotations;

namespace BeFit.Models
{
    public class ExerciseType
    {
        public int Id { get; set; }
        [Display(Name = "Nazwa ćwiczenia")]
        [Required(ErrorMessage = "Podaj nazwę ćwiczenia")]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }
    }
}
