using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WRole.Models
{
    public class Apple
    {
        public int idUserTeacher { get; set; } //Teacher
        public int idUserStudent { get; set; } //Student
        public DateTime date { get; set; }
    }
}