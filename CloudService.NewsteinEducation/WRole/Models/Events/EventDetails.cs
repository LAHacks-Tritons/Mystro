using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WRole.Models.Events
{
    public class EventDetails
    {
        public string status { get; set; }
        
        public int idEvent { get; set; }
        [Key,ForeignKey("idEvent")]
        public virtual Events Events { get; set; }

        public string Id { get; set; }
        [Key, ForeignKey("Id")]
        public virtual IdentityUser User { get; set; }

        


    }
}