using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using dotnet_api_for_angular_bookstore_app.Models;

namespace BookstoreApi.Data
{
    public class BookstoreApiContext : DbContext
    {
        public BookstoreApiContext (DbContextOptions<BookstoreApiContext> options)
            : base(options)
        {
        }

        public DbSet<dotnet_api_for_angular_bookstore_app.Models.BookModel> BookModel { get; set; } = default!;
    }
}
