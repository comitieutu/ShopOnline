using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStore.Implementations
{
    class BookSeeder
    {
        private readonly AppDbContext _context;

        public BookSeeder(AppDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            _context.Database.EnsureCreated();

            if (_context.Categories.Any())
            {

            }

            _context.SaveChanges();
        }
    }
}
