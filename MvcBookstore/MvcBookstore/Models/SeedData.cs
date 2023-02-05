using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcBookstore.Data;
using System;
using System.Linq;

namespace MvcBookstore.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcBookstoreContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcBookstoreContext>>()))
        {
            // Look for any books.
            if (context.Book.Any())
            {
                return;   // DB has been seeded
            }
            context.Book.AddRange(
                new Book
                {
                    Title = "CQRS for Dummies",
                    BookId = "9b0896fa-3880-4c2e-bfd6-925c87f22878",
                },
                new Book
                {
                    Title = "Visual Studio Tips",
                    BookId = "0550818d-36ad-4a8d-9c3a-a715bf15de76",
                },
                new Book
                {
                    Title = "NHibernate Cookbook",
                    BookId = "8e0f11f1-be5c-4dbc-8012-c19ce8cbe8e1",
                }
            );
            context.SaveChanges();
        }
    }
}