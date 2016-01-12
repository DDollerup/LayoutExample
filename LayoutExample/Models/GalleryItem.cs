using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LayoutExample.Models
{
    public class GalleryItem
    {
        public int GalleryItemID { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string AltText { get; set; }
    }
}