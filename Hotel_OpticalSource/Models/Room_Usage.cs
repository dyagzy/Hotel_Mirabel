using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_OpticalSource.Models
{
    public class Room_Usage
    {
        public int Id { get; set; }
        public int Room_Id { get; set; }
        public string Guest_Id { get; set; }

        public bool IsActive { get; set; }
        public DateTime Date { get; set; }

        //finds a particular room by a lazy loading concept
        public virtual Room Room => new ApplicationDbContext().Rooms.Find(Room_Id);
        public virtual Guest Guest => new ApplicationDbContext().Guests.Find(Guest_Id);
    }
}