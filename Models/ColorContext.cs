using Microsoft.EntityFrameworkCore;

namespace ColourAPI.Models
{
    public class ColorContext : DbContext
    {
        public ColorContext(DbContextOptions<ColorContext> options) : base(options)
        {

        }

        public DbSet<Color> ColorItems { get; set; }
    }

}