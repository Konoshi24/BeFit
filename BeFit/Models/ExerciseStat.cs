using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BeFit.Models
{
    public class ExerciseStat
    {
        [Display(Name = "Nazwa ćwiczenia")]
        public string ExerciseName { get; set; }
        [Display(Name = "Liczba wykonań")]
        public int TimesPerformed { get; set; }
        [Display(Name = "Suma powtórzeń")]
        public int TotalRepetitions { get; set; }
        [Display(Name = "średnia waga")]
        public double AverageWeight { get; set; }
        [Display(Name = "Maksymalna waga")]
        public int MaxWeight { get; set; }
        public string? UserId { get; set; }
        [Display(Name = "Użytkownik")]
        public IdentityUser? User { get; set; }
    }
}
