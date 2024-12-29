using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using New_Project.Core.Models;
using New_Project.Domains.Data;
using New_Project.Infrastructure.Iservices;

namespace New_Project.Application.Services
{
    public class AutherService : IAutherService
    {
        private readonly ApplicationDbContext _context;
        public AutherService(ApplicationDbContext context)
        {
            _context = context;

        }
       

        public async Task<object> AddAuther(Auther auther)
        {
            await _context.Authers.AddAsync(auther);
            await _context.SaveChangesAsync();
            return auther;
        }

        public async Task<object> DeleteAuther(int id)
        {
           var auther = await _context.Authers.FindAsync(id);
            _context.Authers.Remove(auther);
            await _context.SaveChangesAsync();
            return auther;
        }

        public async Task<object> GetAuthers()
        {
            var authers = await _context.Authers.ToListAsync();
            if (authers == null) { return null; }
            return authers;
        }

        public async Task<object> GetSomeAuther(int id)
        {
            var auther = await _context.Authers.FindAsync(id);
            if (auther == null) { return null; }
            return auther;
        }

        public async Task<object> UpdateAuther(Auther auther)
        {
            var u = await _context.Authers.Where(r => r.AutherId == auther.AutherId).SingleOrDefaultAsync();
            u.AutherName = auther.AutherName;
            u.BookNum=auther.BookNum;       
            _context.Authers.Update(u);
            await _context.SaveChangesAsync();
            return u;
        }
    }
}
