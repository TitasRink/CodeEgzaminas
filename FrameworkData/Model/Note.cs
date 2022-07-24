using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrameworkData.Model
{
    public class Note
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Message { get; set; }
        public string ImgURL { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public List<Category> Categories { get; set; }

        public Note(string title, string message)
        {
            Name = title;
            Message = message;
            Categories = new List<Category>();
        }
        public Note()
        {

        }
    }
}
