using CvBlazor.ViewModels;
using System;

namespace CvBlazor.Services
{
    public interface ITimelineNodeService
    {
        public Task<IList<TimelineNodeViewModel>> Get();
        public string GetDateInfo(TimelineNodeViewModel node); 
    }
}
