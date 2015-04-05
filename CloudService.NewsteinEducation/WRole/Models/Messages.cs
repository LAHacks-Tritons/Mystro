using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WRole.Models
{
    public class Messages
    {
        [Key]
        public int idMessage { get; set; }
        public int idSender { get; set; }
        public int idReceiver { get; set; }
        public DateTime dateReceived { get; set; }
        public DateTime dateSeen { get; set; }
    }
}