using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace New_Project.Core.Models
{
    public class Auther
    {
        public int AutherId { get; set; }
        [MaxLength(50)]
        public string AutherName { get; set; }
        public int  BookNum { get; set;}
       
        //public int BookId { get; set; }
        //[ForeignKey("BookId")]
        public List<Book> Book { get; set; }  


    }
}
