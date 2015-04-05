using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WRole.Models.Group
{
    public class Group
    {
        [Key]
        public int idGroup { get; set; }

        public string Id { get; set; } //Teacher - Owns Group

        [ForeignKey("Id")]
        public virtual IdentityUser User { get; set; }

        public string description { get; set; }
    }
}