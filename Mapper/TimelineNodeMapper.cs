using AutoMapper;
using CvBlazor.Models;
using CvBlazor.ViewModels;
using System.Globalization;

namespace CvBlazor.Mapper
{
    public class TimelineNodeMapper : Profile
    {
        public TimelineNodeMapper()
        {
            var cultureInfo = new CultureInfo("nl-NL");
            var format = "dd/MM/yyyy";
            CreateMap<TimelineNode, TimelineNodeViewModel>()
                .ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => DateTime.ParseExact(src.StartDate, format, cultureInfo)))
                .ForMember(dest => dest.EndDate, opt => opt.MapFrom(src =>  src.EndDate != null ? DateTime.ParseExact(src.EndDate, format, cultureInfo) : DateTime.MaxValue))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => (NodeType) src.Type));
        }
    }
}
