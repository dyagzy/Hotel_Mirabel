using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_OpticalSource.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }
        public string[] Types => new string [] {"Luxury", "Super Dulux","Peachy Single", "Marriot Double"};
        public bool IsActive { get; set; }
        public DateTime Date { get; set; }
    }
}