using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WRole.Models.Task
{
    public class Task
    {
        [Key]
        public int idTask { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime startDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime dueDate { get; set; }

        public int idTaskType { get; set; }
        [ForeignKey("idTaskType")]
        public virtual TaskType TaskType { get; set; }

        public int idExam { get; set; }
        [ForeignKey("idExam")]
        public virtual Exam.Exam Exam { get; set; } // ?

        public int idStatus { get; set; }


        public string Id { get; set; } // Teacher/Tutor
        [ForeignKey("Id")]
        public virtual IdentityUser User { get; set; }

    }
}