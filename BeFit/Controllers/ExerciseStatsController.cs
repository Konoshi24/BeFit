using BeFit.Data;
using BeFit.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace BeFit.Controllers
{
    [Authorize]
    public class ExerciseStatsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ExerciseStatsController(
            ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            string userId =
              User.FindFirstValue(
                 ClaimTypes.NameIdentifier);

            DateTime fromDate =
                DateTime.Now.AddDays(-28);

            var stats = await _context.Exercise
                .Include(e => e.Session)
                .Include(e => e.ExerciseType)
                .Where(e => e.Session.UserId == userId && e.Session.Start >= fromDate)
                .GroupBy(e => e.ExerciseType.Name)
                .Select(g => new ExerciseStat
                    {
                        ExerciseName = g.Key, 
                        TimesPerformed = g.Count(),
                        TotalRepetitions = g.Sum(x => x.NumOfSeries * x.NumOfReps),
                        AverageWeight = g.Average(x => x.Weight),
                        MaxWeight = g.Max(x => x.Weight)
                    })
                .ToListAsync();
            return View(stats);
        }
    }
}
