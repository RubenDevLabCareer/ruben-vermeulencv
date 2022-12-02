using AutoMapper;
using CvBlazor.Models;
using CvBlazor.ViewModels;
using Microsoft.AspNetCore.Components;

namespace CvBlazor.Mapper
{
    public class HomeProfileMapper : Profile
    {
        public HomeProfileMapper()
        {
            CreateMap<MainProfile, HomeProfileViewModel>()
                .ForMember(dest => dest.InnerHtml, opt => opt.MapFrom(src => (MarkupString) src.InnerHtml));
            CreateMap<MainProfile, HeaderProfileViewModel>();
        }
    }
}
