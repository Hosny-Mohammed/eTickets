using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace eTickets.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext context;
        public ActorsService(AppDbContext _context) 
        {
            context = _context;
        }

        public void Add(Actor actor)
        {

            context.Actors.Add(actor);
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            var actor = context.Actors.FirstOrDefault(x => x.ActorId == id);
            if(actor == null)
                return false;
            context.Actors.Remove(actor);
            context.SaveChanges();
            return true;
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            return await context.Actors.ToListAsync();
        }

        public Actor GetById(int id)
        {
            var Actor = context.Actors.FirstOrDefault(x => x.ActorId == id);
            if(Actor == null)
                return null;
            return Actor;
        }

        public Actor Update(Actor actor)
        {
            context.Actors.Update(actor);  
            context.SaveChanges();
            return actor;
        }
    }
}
