using MediatR;
using TraversalCoreProje.CQRS.Results.GuidResults;

namespace TraversalCoreProje.CQRS.Queries.GuideQueries
{
    public class GetAllGuideQuery :IRequest<List<GetAllGuideQueryResult>>
    {
    }
}
