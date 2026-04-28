using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BeFit.Models
{
    public class Exercise
    {
        [Display(Name = "Identyfikator")]
        public int Id { get; set; }
        [Display(Name = "Waga")]
        [Range(0, 500)]
        public int Weight { get; set; }
        [Display(Name = "Liczba serii")]
        public int NumOfSeries { get; set; }
        [Display(Name = "Liczba powtórzeń")]
        public int NumOfReps { get; set; }
        [Display(Name = "Ćwiczenie")]
        public int ExerciseTypeId { get; set; }
        [Display(Name = "Ćwiczenie")]
        public virtual ExerciseType? ExerciseType { get; set; }
        [Display(Name = "Sesja")]
        public int SessionId { get; set; }
        [Display(Name = "Sesja")]
        public virtual Session? Session { get; set; }
        public string? UserId { get; set; }
        [Display(Name = "Użytkownik")]
        public IdentityUser? User { get; set; }
    }
}
