using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LayoutExample.Models;

namespace LayoutExample.Models.Factories
{
    public class ContactFac
    {
        private Contact contact = new Contact()
        {
            Text = "This is my contact site, you're welcome to contact me.",
            Address = "Awesome Street 42, New York",
            Email = "DoctorDollerp@Awesome.com",
            PhoneNumber = 88888888,
            ImageMap = "Map.jpg"
        };

        public Contact GetContact()
        {
            return contact;
        }
    }
}