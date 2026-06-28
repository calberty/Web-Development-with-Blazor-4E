using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorWebApp.Database.Entities
{
    public class Tag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        // Navigation property for the many-to-many relationship
        // with BlogPosts
        public virtual ICollection<BlogPost> BlogPosts { get; set; }
    }
}
