using APPTest.Data;
using Microsoft.EntityFrameworkCore;

namespace  APPTest.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ASP_MVC_Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ASP_MVC_Context>>()))
            {
                if (context.Pottery.Any())
                {
                    return;   // DB has been seeded
                }
                context.Pottery.AddRange(
                    new Produit
                    {
                        Title = "egg holder",
                        ReleaseDate = DateTime.Parse("2023-2-12"),
                        Price = 7.99M
                    },
                    new Produit
                    {
                        Title = "vase ",
                        ReleaseDate = DateTime.Parse("2023-3-13"),
                        Price = 8.99M
                    },
                    new Produit
                    {
                        Title = "cup",
                        ReleaseDate = DateTime.Parse("2023-2-23"),
                        Price = 9.99M
                    },
                    new Produit
                    {
                        Title = "plate",
                        ReleaseDate = DateTime.Parse("2023-4-15"),
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
