using DataAccessLayer.Concrete;
using Org.BouncyCastle.Asn1.Esf;
using TraversalCoreProje.CQRS.Commands.DestinatinCommands;

namespace TraversalCoreProje.CQRS.Handlers.DestinationHandlers
{
    public class UpdateDestinationCommandHandler
    {
        private readonly Context _context;

        public UpdateDestinationCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateDestinationCommand command)
        {
            var values = _context.Destinations.Find(command.Destinationid);
            values.City = command.City;
            values.DayNight = command.Daynight;
            values.Price = command.Price;
            _context.SaveChanges();
        }
    }
}
