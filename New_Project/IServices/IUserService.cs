using New_Project.Models;

namespace New_Project.IServices
{
    public interface IUserService
    {
        
        public  Task<object> GetSomeUser(int id);
        public Task<object> GetUser();
        public Task<object> AddUser(User user);
        public Task<object> DeleteUser(int id);
        public Task<object> UpdateUser(User user);
    }
}
