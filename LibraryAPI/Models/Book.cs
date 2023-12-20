using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public int IsActive { get; set; }
  
    }
}
