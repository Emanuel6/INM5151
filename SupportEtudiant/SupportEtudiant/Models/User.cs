using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SupportEtudiant.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required]
        public string FisrtName { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}