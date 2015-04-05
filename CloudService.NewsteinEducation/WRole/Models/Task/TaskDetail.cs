using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.AspNet.Identity.EntityFramework;

using System.Web;

namespace WRole.Models.Task
{
    public class TaskDetail
    {
        public string status { get; set; }
        public double result { get; set; }

        
        public int idTask { get; set; }
        [Key,ForeignKey("idTask")]
        public virtual Task Task { get; set; }

        public string Id { get; set; } // Student 
        [Key,ForeignKey("Id")]
        public virtual IdentityUser User { get; set; }
    }
}