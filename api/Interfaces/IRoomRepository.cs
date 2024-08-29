using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Booking;
using api.Dtos.Room;
using api.models;

namespace api.Interfaces {
    public interface IRoomRepository {
       
        Task<List<Room>> GetAllAsync();
        Task<Room?> GetByIdAsync(int id);
        Task<Room?> CreateAsync(Room room);
        Task<Room?> UpdateAsync(int id, UpdateRoomDtos updateRoomDtos);
        Task<Room?> DeleteAsync(int id);
    }
}