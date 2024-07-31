using Microsoft.AspNetCore.Mvc.Rendering;

namespace Bloggie.Web.Models.ViewModels
{
	public class AddBlogPostRequest
	{

		public string Heading { get; set; }
		public string PageTitle { get; set; }
		public string Content { get; set; }
		public string ShortDiscription { get; set; }
		public string FeaturedImageUrl { get; set; }
		public string UrlHandle { get; set; }
		public DateTime PublishedDate { get; set; }
		public string Author { get; set; }
		public bool Visible { get; set; }

        //Display the Tags
        public IEnumerable<SelectListItem> Tags { get; set; }

        //Collect Tags
        public string selectedtag { get; set; }
    }
}
