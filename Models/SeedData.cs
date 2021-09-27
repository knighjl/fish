using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace myWebApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyWebAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MyWebAppContext>>()))
            {
                // Look for any movies.
                if (context.Fish.Any())
                {
                    return;   // DB has been seeded
                }

                context.Fish.AddRange(
                    new Fish
                    {
                        FishType = "Catfish",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Size = "20lb",
                        Place = "Alabama River"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}