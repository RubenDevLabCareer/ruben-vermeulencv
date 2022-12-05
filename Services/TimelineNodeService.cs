using AutoMapper;
using CvBlazor.Models;
using CvBlazor.Repositories;
using CvBlazor.ViewModels;
using System.Diagnostics;
using System.Globalization;

namespace CvBlazor.Services
{
    public class TimelineNodeService : ITimelineNodeService
    {
        private readonly ITimelineNodeRepository _repo;
        private readonly IMapper _mapper;

        public TimelineNodeService(ITimelineNodeRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<IList<TimelineNodeViewModel>> Get()
        {
            return (await _repo.Get())
                .Select(tn => _mapper.Map<TimelineNodeViewModel>(tn))
                .OrderByDescending(tn => tn.StartDate)
                .ToList();
        }

        public string GetDateInfo(TimelineNodeViewModel node)
        {
            static string GetDateString(TimelineNodeViewModel timelineNode, string format)
            {
                var startDateString = timelineNode.StartDate.ToString(format);
                var endDateString = timelineNode.EndDate != DateTime.MaxValue
                        ? timelineNode.EndDate.ToString(format)
                        : "Heden";

                return $"{startDateString} - {endDateString}";
            };

            return node.Type switch
            {
                NodeType.WorkExperience => GetDateString(node, "MMM yyyy"),
                NodeType.Studies => GetDateString(node, "yyyy"),
                _ => GetDateString(node, "dd/MM/yyyy"),
            };
        }
    }
}
