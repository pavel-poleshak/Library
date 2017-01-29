using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Library.Models
{
    public class BookDbInitializer:DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            for (int i = 1; i < 20; i++)
            {
                context.Books.Add(new Book() { Name = "Book " + i, Authors = "Author "+i, PublishingHouse = "Publish House "+i, Description = "Description +i", Price = 100*i });
            }            

            base.Seed(context);
        }
    }
}