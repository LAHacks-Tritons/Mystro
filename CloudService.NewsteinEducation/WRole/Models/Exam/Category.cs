using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WRole.Models.Exam
{
    public class Category
    {
        [Key]
        public int idCategory { get; set; }
        public string description { get; set; }
        
        public virtual Category category { get; set; }

        public int idUser { get; set; } //Teacher
        [ForeignKey("idUser")]
        public virtual IdentityUser User { get; set; }
    }
}