using api.Dtos.Room;
using api.models;

namespace api.Mappers {
    public static class RoomMapper {
        public static RoomDto ToRoomDto(this Room roomModel) {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Id: {0}, Name: {1}, Location: {2} Description: {3}, Price: {4}, ImageUrl: {5}", roomModel.Id, roomModel.Name, roomModel.Location, roomModel.Description, roomModel.Price, roomModel.ImageUrl);
            Console.WriteLine("---------------------------------------------------------------");
            return new RoomDto {
                Id = roomModel.Id,
                Name = roomModel.Name,
                Location = roomModel.Location,
                Description = roomModel.Description,
                Price = roomModel.Price,
                ImageUrl = roomModel.ImageUrl,
            };
        }

        public static Room CreateRoomDto(this CreateRoomDto roomDto) {
            Console.WriteLine("CreateRoomDto RoomMapper.cs", roomDto);

            return new Room {
                Name = roomDto.Name,
                Location = roomDto.Location,
                Description = roomDto.Description,
                Price = roomDto.Price,
                ImageUrl = roomDto.ImageUrl,
            };
        }

        public static Room UpdateRoomDto(this UpdateRoomDto roomDto) {
            return new Room {
                Name = roomDto.Name,
                Location = roomDto.Location,
                Description = roomDto.Description,
                Price = roomDto.Price,
                ImageUrl = roomDto.ImageUrl,
            };
        }
    }   
    
}