using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.Booking;
using api.Dtos.Room;
using api.Interfaces;
using api.models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository {

    public class RoomRepository : IRoomRepository {

    private readonly ApplicationDBContext _context;

    public RoomRepository(ApplicationDBContext context) {
        _context = context;
    }


        public async Task<List<Room>> GetAllAsync() {
            return await _context.Room.ToListAsync();
        }

        public async Task<Room?> GetByIdAsync(int id) {
            return await _context.Room.FindAsync(id);
        }
        public async Task<Room?> CreateAsync(Room room) {
            await _context.Room.AddAsync(room);
            await _context.SaveChangesAsync();
            return room;
        }

        public async Task<Room?> DeleteAsync(int id) {
            var roomModel = await _context.Room.FirstOrDefaultAsync(r => r.Id == id);
            if(roomModel == null) {
                return null;
            }
            _context.Room.Remove(roomModel);
            await _context.SaveChangesAsync();
            return roomModel;
        }

        public Task<Room?> UpdateAsync(int id, UpdateRoomDtos updateRoomDtos) {
            throw new NotImplementedException();
        }
    }
}