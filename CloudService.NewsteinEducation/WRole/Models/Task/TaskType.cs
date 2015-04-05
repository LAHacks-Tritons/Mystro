using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WRole.Models.Task
{
    public class TaskType
    {
        [Key]
        public int idTaskType { get; set; }
        public string description { get; set; }
    }
}