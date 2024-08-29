using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Room;
using api.models;

namespace api.Mappers {
    public static class RoomMapper {

        public static RoomDto ToRoomDto(this Room roomModel) {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Id: {0}, Name: {1}, Description: {2}, Price: {3}, ImageUrl: {4}", roomModel.Id, roomModel.Name, roomModel.Description, roomModel.Price, roomModel.ImageUrl);
            Console.WriteLine("---------------------------------------------------------------");
            return new RoomDto {
                Id = roomModel.Id,
                Name = roomModel.Name,
                Description = roomModel.Description,
                Price = roomModel.Price,
                ImageUrl = roomModel.ImageUrl,
            };
        }

        public static Room CreateRoomDto(this CreateRoomDto roomDto) {
            Console.WriteLine("CreateRoomDto RoomMapper.cs - Mappers [3999]: ", roomDto);

            return new Room {
                Name = roomDto.Name,
                Description = roomDto.Description,
                Price = roomDto.Price,
                ImageUrl = roomDto.ImageUrl,
            };

        }
        
    }
}