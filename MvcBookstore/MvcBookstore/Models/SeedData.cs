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
                    BookingNumber = 0,
                    Description = "This guide is focused on building highly scalable, highly available, and maintainable applications with the Command & Query Responsibility Segregation and the Event Sourcing architectural patterns. It presents a learning journey, not definitive guidance. It describes the experiences of a development team with no prior CQRS proficiency in building, deploying (to Windows Azure), and maintaining a sample real-world, complex, enterprise system to showcase various CQRS and ES concepts, challenges, and techniques." +
                    "The development team did not work in isolation; we actively sought input from industry experts and from a wide group of advisors to ensure that the guidance is both detailed and practical." +
                    "The CQRS pattern and event sourcing are not mere simplistic solutions to the problems associated with large-scale, distributed systems. By providing you with both a working application and written guidance, we expect you’ll be well prepared to embark on your own CQRS journey.",
                },
                new Book
                {
                    Title = "Visual Studio Tips",
                    BookId = "0550818d-36ad-4a8d-9c3a-a715bf15de76",
                    BookingNumber = 0,
                    Description = "Developers who are unaware of these timesaving features surely miss out on opportunities to increase their programming productivity and effectiveness. “Visual Studio Tips and Tricks” explains how to use VS.NET efficiently. Get practical insights into how IDE features work, and how to quickly adapt them for any programming language." +
                    "Organized into short and easy-to-grasp sections, and containing tips and tricks on everything from editing and compiling to debugging and navigating within the VS.NET IDE, this book is a must-read for all .NET developers, regardless of expertise and whether they program in C#, VB.NET, or any other .NET language." +
                    "Specifically, it will provide you with solid guidance and education that will allow you to squeeze the ultimate productivity and use out of the Visual Studio development environment. This book folds in real-world development experience with detailed information about the IDE to make you more productive and ease transition from other development environments. This book demonstrates the new features of the IDE, including code snippets, refactoring, and patterns.",
                },
                new Book
                {
                    Title = "NHibernate Cookbook",
                    BookId = "8e0f11f1-be5c-4dbc-8012-c19ce8cbe8e1",
                    BookingNumber = 0,
                    Description = "This book contains quick-paced self-explanatory recipes organized in progressive skill levels and functional areas. Each recipe contains step-by-step instructions about everything necessary to execute a particular task. The book is designed so that you can read it from start to end or just open up any chapter and start following the recipes. In short this book is meant to be the ultimate how-to reference for NHibernate 3.0, covering every major feature of NHibernate for all experience levels. This book is written for NHibernate users at all levels of experience. Examples are written in C# and XML. Some basic knowledge of SQL is assumed.",
                }
            );
            context.SaveChanges();
        }
    }
}