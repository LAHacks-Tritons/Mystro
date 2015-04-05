using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WRole.Models.Exam
{
    public class QuestionExam
    {
        public int idQuestion { get; set; }
        [Key, ForeignKey("idQuestion")]
        public virtual Question Question { get; set; }

        public int idExam { get; set; }
        [Key, ForeignKey("idExam")]
        public virtual Exam Exam { get; set; }


    }
}