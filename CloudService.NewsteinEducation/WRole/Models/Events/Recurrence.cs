using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WRole.Models.Events
{
    public class Recurrence
    {
        [Key]
        public int idRecurrence { get; set; }
        public string description { get; set; }

    }
}