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
    public class SingleTopicModel : PageModel
    {
        private readonly ITopicsRepository _repo;

        public SingleTopicModel(ITopicsRepository repo)
        {
            _repo = repo;
        }

        public Topic Topic { get; set; }
        public IActionResult OnGet(int id)
        {
            Topic = _repo.GetTopicByID(id);
            return Page();
        }
    }
}
