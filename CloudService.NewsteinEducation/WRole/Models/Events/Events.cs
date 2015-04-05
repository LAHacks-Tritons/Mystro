using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WRole.Models.Events
{
    public class Events
    {
        [Key]
        public int idEvent { get; set; }
        public string description { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime startDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime endDate { get; set; }

        public string eventLocation { get; set; }
        
        public int idRecurrence { get; set; }
        [ForeignKey("idRecurrence")]
        public virtual Recurrence Recurrence { get; set; }

        public string Id { get; set; }
        [ForeignKey("Id")]
        public virtual IdentityUser User { get; set; }
        

    }
}