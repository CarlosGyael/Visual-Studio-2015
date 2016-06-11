using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UltimateProject.Models
{
    public class Items
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        [ForeignKey("ApplicationUser")]
        public string UserID { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}