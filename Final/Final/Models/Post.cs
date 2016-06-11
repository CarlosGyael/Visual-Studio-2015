using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final.Models
{
    public class Post
    {
        [Key]
        public int ID { get; set; }

        public bool Anonymous { get; set; }

        public string Location { get; set; }

        public string Category { get; set; }

        public DateTime Time { get; set; }

        public string Status { get; set; }

        public string GovernmentComment { get; set; }

        public string UserComment { get; set; }

        public string Description { get; set; }

        public string Title { get; set; }

        public int ImageSize { get; set; }

        public string FileName { get; set; }

        public int Likes { get; set; }

        public byte[] ImageData { get; set; }

        public int Number { get; set; }
        
        [NotMapped]
        public HttpPostedFileBase File { get; set; }

        public List<SelectListItem> ListCategory = new List<SelectListItem>();

        public string value { get; set; }

        public string UserID { get; set; }
        
    }
}