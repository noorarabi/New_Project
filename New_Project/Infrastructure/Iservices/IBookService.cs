using New_Project.Core.Models;

namespace New_Project.Infrastructure.Iservices
{
    public interface IBookService
    {
        public Task<object> GetSomeBook(int id);
        public Task<object> GetBooks();
        public Task<object> AddBook(Book book);
        public Task<object> DeleteBook(int id);
        public Task<object> UpdateBook(Book book);
    }
}
