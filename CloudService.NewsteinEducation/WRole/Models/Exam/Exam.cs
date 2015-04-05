using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WRole.Models.Exam
{
    public class Exam
    {
        [Key]
        public int idExam { get; set; }
        public string description { get; set; }
        public double minimumCalification { get; set; }
        public DateTime creationDate { get; set; }
        public DateTime expirationDate { get; set; }


    }
}