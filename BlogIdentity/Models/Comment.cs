using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogIdentity.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Комментарий пользователя")]
        public string UserComment { get; set; }
    }
}
