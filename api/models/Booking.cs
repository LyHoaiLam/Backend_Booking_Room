using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.models {
    public class Booking {
        public int Id { get; set; }
        public  int RoomId { get; set; }
        public string Username { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string Status { get; set; }

    }
}