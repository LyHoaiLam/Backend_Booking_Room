using api.Data;
using api.Dtos.Room;
using api.Helpers;
using api.Interfaces;
using api.models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository {

    public class RoomRepository : IRoomRepository {
        private readonly ApplicationDBContext _context;

        public RoomRepository(ApplicationDBContext context) {
            _context = context;
        }


        // public async Task<List<Room>> GetAllAsync() {
        //     return await _context.Room.ToListAsync();
        // }



// Search theo Tên Vị trí
        public async Task<List<Room>> GetAllAsync(QueryObject query) {
            var roomQuery = _context.Room.AsQueryable();
            if (!string.IsNullOrWhiteSpace(query.Location)) {
                roomQuery = roomQuery.Where(s => s.Location.Contains(query.Location));
            }
            Console.WriteLine("Repository Room");
            return await roomQuery.ToListAsync();
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


        public async Task<Room?> UpdateAsync(int id, UpdateRoomDto roomDto) {
            var roomUpdate = await _context.Room.FirstOrDefaultAsync(r => r.Id == id);
            if (roomUpdate == null) {
                return null;
            }
            roomUpdate.Name = roomDto.Name;
            roomUpdate.Location = roomDto.Location;
            roomUpdate.Description = roomDto.Description;
            roomUpdate.Price = roomDto.Price;
            roomUpdate.ImageUrl = roomDto.ImageUrl;

            await _context.SaveChangesAsync();
            return roomUpdate;
        }
    }
}