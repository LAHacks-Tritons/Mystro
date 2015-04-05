using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WRole.Models.Answers
{
    public class Answers
    {
        [Key]
        public int idAnswer { get; set; }
        public string description { get; set; }
        public bool isCorrect { get; set; }

        public int idQuestion { get; set; }
        [ForeignKey("idQuestion")]
        public virtual Exam.Question Question { get; set; }
    }
}