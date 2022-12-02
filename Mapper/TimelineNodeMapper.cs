using AutoMapper;
using CvBlazor.Models;
using CvBlazor.ViewModels;

namespace CvBlazor.Mapper
{
    public class TimelineNodeMapper : Profile
    {
        public TimelineNodeMapper()
        {
            CreateMap<TimelineNode, TimelineNodeViewModel>()
                .ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => Convert.ToDateTime(src.StartDate)))
                .ForMember(dest => dest.EndDate, opt => opt.MapFrom(src => Convert.ToDateTime(src.EndDate)))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => (NodeType) src.Type));
        }
    }
}
