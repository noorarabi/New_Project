using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace New_Project.Core.Models
{
    public class Book
    {
        
        public int BookId { get; set; }

        [MaxLength(100)]
        [MinLength(1)]
        [Required]  
        public string Title { get; set; }
        [MaxLength(300)]
        [MinLength(1)]
        [DataType(DataType.MultilineText)]
        [Required]
        public string Description { get; set; }
        
        public int AutherId { get; set; }
        [ForeignKey("AutherId")]
        public Auther Auther { get; set; }  
    }
}
