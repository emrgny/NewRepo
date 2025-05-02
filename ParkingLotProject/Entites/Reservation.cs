using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotProject.Entites
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        public string ParkingAreaNumber { get; set; }
        public DateTime EntryTime { get; set; }
        public DateTime ExitTime { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
    }
}
