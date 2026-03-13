using System;
using System.Collections.Generic;
using System.Text;
namespace crudPVmodels

{
    public class VendorModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }

        public override string ToString()
        {
            return " Name : " + Name +
                   " | Address: " + Address +
                   " | Contact: " + Contact;
        }
    }
}