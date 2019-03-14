using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecipeOrganizer.Data;
using RecipeOrganizer.Models;

namespace RecipeOrganizer.Pages.Recipes
{
    public class IndexModel : PageModel
    {
        private readonly RecipeOrganizer.Data.ApplicationDbContext _context;

        public IndexModel(RecipeOrganizer.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Recipe> Recipe { get;set; }

        public async Task OnGetAsync()
        {
            Recipe = await _context.Recipe.ToListAsync();
        }
    }
}
