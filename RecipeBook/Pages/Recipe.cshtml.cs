using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RecipeBook.Data;
using RecipeBook.Data.Model;

namespace RecipeBook.Pages
{
    public class RecipeModel : PageModel
    {
        private ApplicationDbContext _context;

        [BindProperty]
        public Recipe Recipe { get; set; }

        public RecipeModel(ApplicationDbContext context) {
            _context = context;
        }

        public void OnGet(int id)
        {
            Recipe = id == 0 ? new Recipe() : _context.Recipes.Find(new object[] { id });
        }
    }
}
