namespace TraversalCoreProje.CQRS.Commands.DestinatinCommands
{
    public class RemoveDestinationCommands
    {
        public RemoveDestinationCommands(int id)
        {
            Id = id;
        }

        public  int Id { get; set; }

    }
}
