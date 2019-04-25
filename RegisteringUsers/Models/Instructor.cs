using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegisteringUsers.Models
{
    public class Instructor
    {
        [Key]
        [StringLength(128)]
        public string InstructorId { get; set; }

        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public byte MajorCode { get; set; }
    }
}