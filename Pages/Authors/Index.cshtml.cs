using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Oltean_Andreea_Lab2.Models;

namespace Oltean_Andreea_Lab2.Pages.AuthorPages;

public class IndexModel : PageModel
{
    private readonly Oltean_Andreea_Lab2Context _context;

    public IndexModel(Oltean_Andreea_Lab2Context context)
    {
        _context = context;
    }

    public IList<Author> Author { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Author = await _context.Author.ToListAsync();
    }
}
