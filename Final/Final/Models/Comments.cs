using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Final.Models
{
    public class Comments
    {
        [Key]
        public int ID { get; set; }

        public string User { get; set; }

        public int PostID {get; set;}

        public string Comment { get; set; }

        public DateTime Time { get; set; }
    }
}