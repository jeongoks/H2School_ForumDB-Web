using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using H2School_ForumDB_Web.Repositories;
using H2School_ForumDB_Web.Models;

namespace H2School_ForumDB_Web.Pages
{
    public class CreateTopicModel : PageModel
    {
        private readonly ITopicsRepository _repo;

        public CreateTopicModel(ITopicsRepository repo)
        {
            _repo = repo;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Topic Topic { get; set; }

        public IActionResult OnPost()
        {
            _repo.CreateTopic(Topic.HeadLine, Topic.BodyText, Topic.UserID, Topic.CategoryID);
            return RedirectToPage("/Index");
        }
    }
}
