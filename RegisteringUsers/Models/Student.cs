using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegisteringUsers.Models
{
    public class Student
    {
        [Key]
        [StringLength(128)]
        public string StudentId { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte MajorCode { get; set; }
    }
}