using CvBlazor.Models;

namespace CvBlazor.Repositories
{
    public interface ITimelineNodeRepository
    {
        public Task<IEnumerable<TimelineNode>> Get(); 
    }
}
