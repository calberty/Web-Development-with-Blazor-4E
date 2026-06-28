using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorWebApp.Database.Entities
{
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // Foreign key to BlogPost
        public int BlogPostId { get; set; }

        // Navigation property to BlogPost
        public virtual BlogPost BlogPost { get; set; }

        public DateTime Date { get; set; }

        public string Text { get; set; } = string.Empty;
        
        public string Name { get; set; } = string.Empty;
    }
}
