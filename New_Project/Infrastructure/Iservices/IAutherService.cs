using New_Project.Core.Models;

namespace New_Project.Infrastructure.Iservices
{
    public interface IAutherService
    {
        public Task<object> GetSomeAuther(int id);
        public Task<object> GetAuthers();
        public Task<object> AddAuther(Auther auther);
        public Task<object> DeleteAuther(int id);
        public Task<object> UpdateAuther(Auther auther);
    }
}
