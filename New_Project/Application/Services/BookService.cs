using Microsoft.EntityFrameworkCore;
using New_Project.Core.Models;
using New_Project.Domains.Data;
using New_Project.Infrastructure.Iservices;

namespace New_Project.Application.Services
{
    public class BookService : IBookService
    {
        private readonly ApplicationDbContext _context;
        public BookService(ApplicationDbContext context)
        {
            _context = context;

        }
        public async Task<object> AddBook(Book book)
        {
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();
            return book;
        }

        public async Task<object> DeleteBook(int id)
        {
            var book = await _context.Books.FindAsync(id);
             _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            return book;
        }

        public async Task<object> GetBooks()
        {
            var books = await _context.Books.ToListAsync();
            if (books == null) { return null; }
            return books;
        }

        public async Task<object> GetSomeBook(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null) { return null; }
            return book; 
        }

        public async Task<object> UpdateBook(Book book)
        {
            var u = await _context.Books.Where(r => r.BookId == book.BookId).SingleOrDefaultAsync();
            u.Title = book.Title;
            u.Description = book.Description;
            _context.Books.Update(u);
            await _context.SaveChangesAsync();
            return u;
        }
    }
}
