using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Oltean_Andreea_Lab2.Models;
using Oltean_Andreea_Lab2.Data;

namespace Oltean_Andreea_Lab2.Pages.MemberPages;

public class IndexModel : PageModel
{
    private readonly Oltean_Andreea_Lab2Context _context;

    public IndexModel(Oltean_Andreea_Lab2Context context)
    {
        _context = context;
    }

    public IList<Member> Member { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Member = await _context.Member.ToListAsync();
    }
}
