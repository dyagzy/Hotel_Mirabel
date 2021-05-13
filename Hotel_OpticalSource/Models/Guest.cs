using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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


        //[NotMapped]
        /*returns a list of all the guest*/

        // public virtual List<Guest> Guests => new ApplicationDbContext().Guests.ToList();
        public virtual List<Room_Usage> Room_Usages =>
            new ApplicationDbContext().Room_Usage.ToList().ToList().Where(x => x.Guest_Id == Id).ToList();
    }



}