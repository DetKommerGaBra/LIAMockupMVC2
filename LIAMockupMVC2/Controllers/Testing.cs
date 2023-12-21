using LIAMockupMVC2.Data;
using LIAMockupMVC2.Models.ViewModel;
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

        public async Task<IActionResult> TestingQuestionsJoin()
        {

            var allQsWithAnswerInfo = await (from a in _context.Answers
                                             join q in _context.Questions on a.FK_QuestionId equals q.QuestionId
                                             join ug in _context.UserGroups on a.FK_UserGroupId equals ug.UserGroupId
                                             join g in _context.Groups on ug.FK_GroupId equals g.GroupId
                                             join o in _context.Organizations on g.FK_OrgId equals o.OrgId
                                             select new QsInfoViewModel
                                             {
                                                 QuestionText = q.QuestionText,
                                                 QuestionNum = q.QuestionNum,
                                                 AnswerText = a.AnswerText,
                                                 AnswerNum = a.AnswerNum,
                                                 GroupName = g.GroupName,
                                                 OrgName = o.OrgName
                                             }).ToListAsync();

            //var allQsWithAnswerInfo = await (from a in _context.Answers
            //                                        from g in _context.Groups
            //                                        from o in _context.Organizations
            //                                        join q in _context.Questions on a.FK_QuestionId equals q.QuestionId
            //                                        join ug in _context.UserGroups on a.FK_UserGroupId equals ug.UserGroupId
            //                                        join gug in _context.UserGroups on g.GroupId equals gug.FK_GroupId
            //                                        join go in _context.Groups on o.OrgId equals go.FK_OrgId
            //                                        select new QsInfoViewModel
            //                                        {
            //                                            QuestionText = q.QuestionText,
            //                                            QuestionNum = q.QuestionNum,
            //                                            AnswerText = a.AnswerText,
            //                                            AnswerNum = a.AnswerNum,
            //                                            GroupName = g.GroupName,
            //                                            OrgName = o.OrgName.Where(o.OrgId == g.FK_OrgId)
            //                                        }).ToListAsync();


            ViewData["allQuestionsWithAnswerInfo"] = allQsWithAnswerInfo;

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
