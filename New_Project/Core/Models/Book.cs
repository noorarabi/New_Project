using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace New_Project.Core.Models
{
    public class Book
    {
        
        public int BookId { get; set; }

      
        public string Title { get; set; }
       
        public string Description { get; set; }
        public bool ISDeleted { get; set; } 
        public int AutherId { get; set; }
      
        public Auther Auther { get; set; }  
    }
}
