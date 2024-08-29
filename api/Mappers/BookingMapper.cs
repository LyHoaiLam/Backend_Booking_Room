using api.Dtos.Booking;
using api.models;

namespace api.Mappers {
    public static class BookingMapper {
        public static BookingDtos ToRBookingDto(this Booking bookingModel) {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Id: {0}, RoomId: {1}, Username: {2}, CheckInDate: {3}, Status: {4}", bookingModel.Id, bookingModel.RoomId, bookingModel.Username, bookingModel.CheckInDate, bookingModel.Status);
            Console.WriteLine("---------------------------------------------------------------");
            return new BookingDtos {
                Id = bookingModel.Id,
                RoomId = bookingModel.RoomId,
                Username = bookingModel.Username,
                CheckInDate = bookingModel.CheckInDate,
                Status = bookingModel.Status,
            };
        }


        public static Booking CreateBookingDto(this CreateBookingDtos bookingDto) {
            Console.WriteLine("CreateBookingDto BookingMapper.cs", bookingDto);

            return new Booking {
                RoomId = bookingDto.RoomId,
                Username = bookingDto.Username,
                CheckInDate = bookingDto.CheckInDate,
                Status = bookingDto.Status,
            };
        }
    }

}