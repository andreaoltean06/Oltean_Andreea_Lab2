using Microsoft.EntityFrameworkCore;

public class Oltean_Andreea_Lab2Context(DbContextOptions<Oltean_Andreea_Lab2Context> options) : DbContext(options)
{
    public DbSet<Oltean_Andreea_Lab2.Models.Book> Book { get; set; } = default!;
    public DbSet<Oltean_Andreea_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    public DbSet<Oltean_Andreea_Lab2.Models.Author> Author { get; set; } = default!;
}
