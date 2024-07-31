using Microsoft.AspNetCore.Mvc;

namespace Bloggie.Web.Controllers
{
	public class AdminBlogPostController : Controller
	{
		private readonly ITagRepository tagRepoitory;
        public AdminBlogPostController(ITagRepository tagRepository)
        {
				this.tagRepoitory = tagRepository;
        }

        [HttpGet]
		public IActionResult Add()
		{
		//gets tag from the repository

			var tags = tagRepoitory.GetAll();
			return View();
		}
	}
}
