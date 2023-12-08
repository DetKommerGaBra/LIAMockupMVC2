using LIAMockupMVC2.Data;
using Microsoft.AspNetCore.Mvc;

namespace LIAMockupMVC2.Controllers
{
    public class Testing : Controller
    {
        private readonly AppDbContext _context;
        public Testing(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> TestingUser()
        {
            var allUsers = await _context.Users.ToListAsync();

            ViewData["Users"] = allUsers;

            return View();
        }

        public async Task<IActionResult> TestingQuestions()
        {
            var allQuestions = await _context.Questions.ToListAsync();

            ViewData["Questions"] = allQuestions;

            return View();
        }

        public async Task<IActionResult> TestingAnswers()
        {
            var allAnswers = await _context.Answers.ToListAsync();

            ViewData["Answers"] = allAnswers;

            return View();
        }

        public async Task<IActionResult> TestingGroups()
        {
            var allGroups = await _context.Groups.ToListAsync();

            ViewData["Groups"] = allGroups;

            return View();
        }

        public async Task<IActionResult> TestingOrganizations()
        {
            var allOrganizations = await _context.Organizations.ToListAsync();

            ViewData["Organizations"] = allOrganizations;

            return View();
        }
    }
}
