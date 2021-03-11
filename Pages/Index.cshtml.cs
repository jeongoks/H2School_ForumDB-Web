using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using H2School_ForumDB_Web.Repositories;
using H2School_ForumDB_Web.Models;

namespace H2School_ForumDB_Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ITopicsRepository _repo;

        public IndexModel(ILogger<IndexModel> logger, ITopicsRepository repo)
        {
            _logger = logger;
            _repo = repo;
        }

        public IList<Topic> Topic { get; set; }

        public void OnGet()
        {
            Topic = _repo.GetAllTopics();
        }
    }
}
