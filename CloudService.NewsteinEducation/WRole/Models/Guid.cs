using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WRole.Models
{
    public class Guid
    {
        [Key]
        public string idGuid { get; set; }
        public string guid { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime expirationDate { get; set; }
    }
}