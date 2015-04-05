using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WRole.Models.User
{
    public class Roles
    {
        [Key]
        public int idRole { get; set; }
        public string descripion { get; set; }

        public string Id { get; set; }
        [ForeignKey("Id")]
        public virtual IdentityUser User { get; set; }
    }
}