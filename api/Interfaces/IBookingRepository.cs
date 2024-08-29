using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Booking;
using api.Dtos.Room;
using api.models;

namespace api.Interfaces {
    public interface IBookingRepository {
        Task<List<Booking>> GetAllAsync();
        Task<Booking?> GetByIdAsync(int id);
        Task<Booking?> CreateAsync(Booking booking);
        Task<Booking?> UpdateAsync(int id, UpdateBookingDtos updateBookingDtos);
        Task<Booking?> DeleteAsync(int id);

    }
}