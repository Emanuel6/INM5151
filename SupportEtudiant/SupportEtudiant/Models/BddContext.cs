using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SupportEtudiant.Models
{
    public class BddContext : DbContext
    {
            public DbSet<User> User { get; set; }
            public DbSet<ForumPost> ForumPost { get; set; }
    }
}