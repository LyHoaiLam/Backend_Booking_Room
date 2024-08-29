using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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







        public Task<Booking?> CreateAsync(Booking booking) {
            throw new NotImplementedException();
        }

        public Task<Booking?> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }



        public Task<Booking?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Booking?> UpdateAsync(int id, UpdateBookingDtos updateBookingDtos)
        {
            throw new NotImplementedException();
        }
    }
}