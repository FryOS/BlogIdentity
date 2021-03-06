using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BlogIdentity.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Имя статьи")]
        public string Title { get; set; }
        public string Content { get; set; }

        public List<Tag> Tags { get; set; }
        
    }
}
