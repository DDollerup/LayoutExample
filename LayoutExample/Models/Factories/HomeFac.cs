using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LayoutExample.Models;

namespace LayoutExample.Models.Factories
{
    public class HomeFac
    {
        private Home home = new Home()
        {
            Text = "Welcome to my awesome website, you're welcome to browse around.",
            Image1 = "Obama.jpg",
            Image2 = "WhiteHouse.jpg"
        };

        public Home GetHome()
        {
            return home;
        }
    }
}