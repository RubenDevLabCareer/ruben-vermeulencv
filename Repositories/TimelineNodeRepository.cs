using CvBlazor.Models;

namespace CvBlazor.Repositories
{
    public class TimelineNodeRepository : JsonRepository<TimelineNode>, ITimelineNodeRepository
    {
        public TimelineNodeRepository(HttpClient client) : base(client, "data/timelineNodes.json")
        {
        }
    }
}
