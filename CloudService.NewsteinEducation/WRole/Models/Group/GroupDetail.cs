using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WRole.Models.Group
{
    public class GroupDetail
    {
        //Foreign & Primary key?
        public int idGroup { get; set; }
        [Key,ForeignKey("idGroup")]
        public virtual Group Group { get; set; }

        public int idUser { get; set; } // Student 
        [Key,ForeignKey("idUser")]
        public virtual IdentityUser User { get; set; }

    }
}