using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LayoutExample.Models;

namespace LayoutExample.Models.Factories
{
    public class GalleryFac
    {
        List<GalleryItem> gallery = new List<GalleryItem>()
        {
            new GalleryItem()
            {
                 GalleryItemID = 1,
                 Image = "Map.jpg",
                 AltText = "This is a map of something",
                 Title ="Map"
            },
            new GalleryItem()
            {
                GalleryItemID = 2,
                Image = "Obama.jpg",
                AltText = "President of USA",
                Title = "President"
            },
            new GalleryItem()
            {
                GalleryItemID = 3,
                Image = "WhiteHouse.jpg",
                AltText ="This is where the president lives",
                Title ="White House"
            }
        };

        public List<GalleryItem> GetGalleryItems()
        {
            return gallery;
        }
    }
}