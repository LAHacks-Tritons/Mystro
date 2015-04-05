using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WRole.Models.Exam
{
    public class QuestionType
    {
        [Key]
        public int idQuestionType { get; set; }
        public string description { get; set; }
    }
}