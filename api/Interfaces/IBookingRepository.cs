using api.Dtos.Booking;
using api.models;

namespace api.Interfaces {
    public interface IBookingRepository {
        Task<List<Booking>> GetAllAsync();
        Task<Booking?> GetByIdAsync(int id);
        Task<Booking?> CreateAsync(Booking booking);
        Task<Booking?> UpdateAsync(int id, UpdateBookingDto updateBookingDtos);
        Task<Booking?> DeleteAsync(int id);

    }
}