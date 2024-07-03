using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAll();
        void Add(Actor actor);
        Actor GetById(int id);
        Actor Update(Actor actor);
        bool Delete(int id);
    }
}
