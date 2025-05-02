using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotProject.Entites
{
    public class Vehicle
    {
        public int VehicleID { get; set; }
        public string VehiclePlate { get; set; }
        public string VehicleType { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
    }
}
