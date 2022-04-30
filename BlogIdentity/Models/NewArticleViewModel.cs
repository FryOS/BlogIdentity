using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace BlogIdentity.Models
{
    public class NewArticleViewModel
    {
        public Article Articles { get; set; }
        
        public IEnumerable<Tag> TagsList { get; set; }  
        
    }
}
