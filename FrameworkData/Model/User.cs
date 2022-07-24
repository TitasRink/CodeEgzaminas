using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FrameworkData.Model
{
    public class User 
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Password { get; set; }
        public List<Note> Notes { get; set; }

        public User(string name, string password)
        {
            Name = name;
            Password = password;
            Notes = new List<Note>();
        }
    }
}
