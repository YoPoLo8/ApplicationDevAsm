using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Assignment.Models
{
    public class Category
    {
        public int Id { get; set; }
        [MinLength(2)]
        [MaxLength(55)]
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
