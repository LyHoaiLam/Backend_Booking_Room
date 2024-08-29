namespace api.Dtos.Booking {
    public class CreateBookingDto {
        public  int RoomId { get; set; }
        public string Username { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string Status { get; set; }
    }
}