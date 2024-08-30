using api.Dtos.Room;
using api.Helpers;
using api.models;

namespace api.Interfaces {
    public interface IRoomRepository {
        Task<List<Room>> GetAllAsync(QueryObject query);
        Task<Room?> GetByIdAsync(int id);
        Task<Room?> CreateAsync(Room room);
        Task<Room?> UpdateAsync(int id, UpdateRoomDtos updateRoomDtos);
        Task<Room?> DeleteAsync(int id);
    }
}