namespace api.Dtos.Room {
    public class UpdateRoomDtos {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public int? BookingId { get; set; }

    }
}