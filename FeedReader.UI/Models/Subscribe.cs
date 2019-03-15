using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FeedsReader.UI.Models
{
    public class Subscribe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public System.Guid SubscribeID { get; set; }
        public string UserID { get; set; }
        public string FeedID { get; set; }
        public string SubName { get; set; }
        public string SubUrl { get; set; }
        public string SubImageURl { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}