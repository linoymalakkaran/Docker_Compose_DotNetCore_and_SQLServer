using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace ColourAPI.Models
{
    public static class PrepDB
    {
        public static void PrePopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<ColorContext>());
            }
        }

        public static void SeedData(ColorContext context)
        {
            System.Console.WriteLine("Application Migration");
            context.Database.Migrate();
            if (!context.ColorItems.Any())
            {
                System.Console.WriteLine("Adding data");
                context.ColorItems.AddRange(
                  new Color()
                  {
                      ColorName = "red",
                  }, new Color()
                  {
                      ColorName = "orange",
                  }, new Color()
                  {
                      ColorName = "black",
                  }, new Color()
                  {
                      ColorName = "yellow",
                  }
                );
                context.SaveChanges();
            }
            else
            {
                System.Console.WriteLine("Already have data.");
            }
        }
    }
}