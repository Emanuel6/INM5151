using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SupportEtudiant.Models
{
    public class ForumPost
    {
        public int ForumPostId { get; set; }
        public virtual User User { get; set; }
        public virtual ForumPost ParentPost { get; set; }
    }
}