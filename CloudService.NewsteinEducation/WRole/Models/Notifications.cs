using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WRole.Models
{
    public class Notifications
    {
        [Key]
        public int idNotification { get; set; }
        public int idType { get; set; }
        public int idReference { get; set; }
        public DateTime dataCreated { get; set; }
        public DateTime dataSeen { get; set; }
    }
}