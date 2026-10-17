using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Oltean_Andreea_Lab2.Models;

namespace Oltean_Andreea_Lab2.Pages.AuthorPages;

public class DetailsModel : PageModel
{
    private readonly Oltean_Andreea_Lab2Context _context;
    public DetailsModel(Oltean_Andreea_Lab2Context context)
    {
        _context = context;
    }

    public Author Author { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var book = await _context.Author.FirstOrDefaultAsync(m => m.ID == id);
        if (book is null)
        {
            return NotFound();
        }
        else
        {
            Author = book;
        }

        return Page();
    }
}
