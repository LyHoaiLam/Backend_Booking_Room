using api.models;

namespace api.Interfaces {
    public interface IAuthorListRepository{
        Task<List<Booking>> GetUserAuthorList(AppUser user);
    }
}