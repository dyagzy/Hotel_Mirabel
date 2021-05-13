using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        //[NotMapped]
        //returns a list of all the rooms
        //public virtual List<Room> Rooms => new ApplicationDbContext().Rooms.ToList();
        public virtual List<Room_Usage> Room_Usages => 
            new ApplicationDbContext().Room_Usage.ToList().ToList().Where(x => x.Room_Id == Id).ToList();
    }
}