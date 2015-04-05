using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WRole.Models.Exam
{
    public class Question
    {
        [Key]
        public int idQuestion { get; set; }
        public string description { get; set; }
        public string hint { get; set; }

        public int idCategory { get; set; }
        [ForeignKey("idCategory")]
        public virtual Category Category { get; set; }

        public int idQuestionType { get; set; }
        [ForeignKey("idQuestionType")]
        public virtual QuestionType QuestionType { get; set; }
    }
}