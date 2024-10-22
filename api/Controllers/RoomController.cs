using api.Data;
using api.Dtos.Room;
using api.Helpers;
using api.Interfaces;
using api.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers {
    [Route("api/Room")]
    [ApiController]
    public class RoomController : ControllerBase {
        private readonly ApplicationDBContext _context;
        private readonly IRoomRepository _roomRepo;
        private readonly IBookingRepository _bookingRepo;

        public RoomController(ApplicationDBContext context, IRoomRepository roomRepo, IBookingRepository bookingRepo) {
            _context = context;
            _roomRepo = roomRepo;
            _bookingRepo = bookingRepo;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllRoom([FromQuery] QueryObject query) {
            var rooms = await _roomRepo.GetAllAsync(query);
            var roomDto = rooms.Select(s => s.ToRoomDto());
            Console.WriteLine("Controller Room");
            return Ok(roomDto);
        }


        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetByIdRoom([FromRoute] int id) {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            var room = await _roomRepo.GetByIdAsync(id);
            if(room == null) {
                return NotFound();
            }
            return Ok(room.ToRoomDto());
        }

        [HttpPut("{id:int}")]

        public async Task<IActionResult> UpdateRoom([FromRoute] int id, UpdateRoomDto roomDto) {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            var roomUpdate = await _roomRepo.UpdateAsync(id, roomDto);
            if (roomUpdate == null) {
                return NotFound();
            }

            return Ok(roomUpdate.ToRoomDto());
        }


        [HttpPost]
        public async Task<IActionResult> CreateRoom(CreateRoomDto roomDto) {
            var roomModel = roomDto.CreateRoomDto();
            await _roomRepo.CreateAsync(roomModel);
            return CreatedAtAction(nameof(GetByIdRoom), new {id = roomModel.Id}, roomModel.ToRoomDto());
        }

    }
}