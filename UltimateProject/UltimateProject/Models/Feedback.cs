using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UltimateProject.Models
{
    public class Feedback
    {
        [Key]
        public int ID { get; set; }

        public DateTime Time { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required]
        public string Message { get; set; }

        [ForeignKey("ApplicationUser")]
        public string UserID { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}