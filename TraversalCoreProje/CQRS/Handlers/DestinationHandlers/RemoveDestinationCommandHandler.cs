using DataAccessLayer.Concrete;
using TraversalCoreProje.CQRS.Commands.DestinatinCommands;

namespace TraversalCoreProje.CQRS.Handlers.DestinationHandlers
{
    public class RemoveDestinationCommandHandler
    {
        private readonly Context _context;

        public RemoveDestinationCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(RemoveDestinationCommands commend)
        {
            var values = _context.Destinations.Find(commend.Id);
            _context.Destinations.Remove(values);
            _context.SaveChanges();
        }
    }
}