using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace WebProject.Models
{
    public class Marker
    {
        [Key]

        public int Id { get; set; }
        public int Color { get; set; }
        public double Money{ get; set; }
        public string Notes { get; set; }
        public string userId { get; set; }
    }
}