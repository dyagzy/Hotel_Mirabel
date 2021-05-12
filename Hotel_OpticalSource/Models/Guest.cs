using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_OpticalSource.Models
{
    public class Guest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public DateTime Date { get; set; }
    }
}