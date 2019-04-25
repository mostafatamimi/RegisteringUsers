using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegisteringUsers.Models
{
    public class RefMajor
    {
        [Key]
        public byte MajorCode { get; set; }
        public string MajorDesc { get; set; }
    }
}