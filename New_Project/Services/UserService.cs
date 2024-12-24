using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using New_Project.Domains.Data;
using New_Project.IServices;
using New_Project.Models;

namespace New_Project.Services
{
    public class UserService : IUserService
    {
         
        private readonly ApplicationDbContext _context;
        public UserService(ApplicationDbContext context)
        {
            _context = context; 
            
        }

        public async Task<object> AddUser(User user)
        {
           await _context.User.AddAsync(user);
           await _context.SaveChangesAsync();  
           return user;
        }

        public async Task<object> GetSomeUser(int id)
        {
            var user = await _context.User.FindAsync(id);
            if (user == null) { return null; }
            return user;
        }

        public async Task<object> GetUser()
        {
            var user = await _context.User.ToListAsync();
            if (user == null) { return null; }
            return user;
        }
        public async Task<object> DeleteUser(int id)
        {
            var user = await _context.User.FindAsync(id);
            _context.User.Remove(user); 
            await _context.SaveChangesAsync(); 
            return user;
        }
        public async Task<object> UpdateUser(User user)
        {
            var u = await _context.User.Where(r=>r.Id==user.Id).SingleOrDefaultAsync();
            u.Name=user.Name;
            _context.User.Update(u);
            await _context.SaveChangesAsync();
            return u;
        }
    }
}
