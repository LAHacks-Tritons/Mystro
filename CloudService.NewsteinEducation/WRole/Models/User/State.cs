using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WRole.Models.User
{
    public class State
    {
        [Key]
        public int idState { get; set; }
        public string description { get; set; }

        public int idCountry { get; set; }
        [ForeignKey("idCountry")]
        public virtual Country Country { get; set; }
    }
}