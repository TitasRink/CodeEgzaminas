using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FrameworkData.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
      
        public List<Note> Notes { get; set; }
        public int UserId { get; set; }

        public Category(string name)
        {
            Name = name;
            Notes = new List<Note>();
        }
    }
}
