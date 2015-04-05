using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WRole.Models.Answers
{
    public class OpenStudentAnswer
    {
        public string Id { get; set; } //Student
        [Key, ForeignKey("Id")]
        public virtual IdentityUser User { get; set; }

        public int idQuestion { get; set; }
        [Key, ForeignKey("idQuestion")]
        public virtual Exam.Question Question  { get; set; }

        public int idAnswer { get; set; }
        [Key, ForeignKey("idAnswer")]
        public virtual Answers Answers { get; set; }

        public int idExam { get; set; }
        [Key, ForeignKey("IdExam")]
        public virtual Exam.Exam Exam { get; set; }

        public string answerContent { get; set; }
        public bool isCorrect { get; set; }
    }
}