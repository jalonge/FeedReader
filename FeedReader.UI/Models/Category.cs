using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FeedsReader.UI.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public System.Guid CategoryID { get; set; }
        public int Id { get; set; }

        public string CategoryName { get; set; }

        public bool IsDeleted { get; set; }
        public IEnumerable<FeedReader.Feed> Feeds { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}