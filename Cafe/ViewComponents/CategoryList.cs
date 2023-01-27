using Cafe.Data;
using Microsoft.AspNetCore.Mvc;

namespace Cafe.ViewComponents
{
	public class CategoryList : ViewComponent
	{
		private readonly ApplicationDbContext _db;
		public CategoryList(ApplicationDbContext db)
		{

		}
	}
}
