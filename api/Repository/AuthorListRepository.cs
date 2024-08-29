using api.Data;
using api.Interfaces;
using api.models;

namespace api.Repository {
    public class AuthorListRepository : IAuthorListRepository {
        private readonly ApplicationDBContext _context;

        public AuthorListRepository(ApplicationDBContext context) {
            _context = context;
        }

        public Task<List<Booking>> GetUserAuthorList(AppUser user) {
            throw new NotImplementedException();
        }
    }
}