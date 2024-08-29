using api.Data;
using api.Dtos.Booking;
using api.Interfaces;
using api.models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository {
    public class BookingRepository : IBookingRepository {
        private readonly ApplicationDBContext _context;

        public BookingRepository(ApplicationDBContext context) {
            _context = context;
        }

        public async Task<List<Booking>> GetAllAsync() {
            return await _context.Booking.ToListAsync();
        }

        public async Task<Booking?> GetByIdAsync(int id) {
            return await _context.Booking.FindAsync(id);
        }

        public async Task<Booking?> CreateAsync(Booking booking) {
            await _context.Booking.AddAsync(booking);
            await _context.SaveChangesAsync();
            return booking;
        }

        public async Task<Booking?> DeleteAsync(int id) {
            var bookingModel = await _context.Booking.FirstOrDefaultAsync(r => r.Id == id);
            if(bookingModel == null) {
                return null;
            }
            _context.Booking.Remove(bookingModel);
            await _context.SaveChangesAsync();
            return bookingModel;
        }








        public Task<Booking?> UpdateAsync(int id, UpdateBookingDto updateBookingDtos) {
            throw new NotImplementedException();
        }
    }
}