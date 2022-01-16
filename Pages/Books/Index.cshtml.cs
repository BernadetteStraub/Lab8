using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Straub_Bernadette_Lab8.Data;
using Straub_Bernadette_Lab8.Models;

namespace Straub_Bernadette_Lab8.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Straub_Bernadette_Lab8Context _context;

        public IndexModel(Straub_Bernadette_Lab8Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context
                .Book
                .Include(p => p.Publisher)
                .ToListAsync();
        }
    }
}
