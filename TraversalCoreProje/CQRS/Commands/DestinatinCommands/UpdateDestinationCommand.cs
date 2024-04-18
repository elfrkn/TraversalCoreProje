namespace TraversalCoreProje.CQRS.Commands.DestinatinCommands
{
    public class UpdateDestinationCommand
    {
        public int Destinationid { get; set; }
        public string City { get; set; }
        public string Daynight { get; set; }
        public double Price { get; set; }
    }
}
