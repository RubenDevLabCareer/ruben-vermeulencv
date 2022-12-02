using AutoMapper;
using CvBlazor.Models;
using CvBlazor.ViewModels;

namespace CvBlazor.Mapper
{
    public class ProjecteMapper : Profile
    {
        public ProjecteMapper()
        {
            CreateMap<Project, ProjectBaseViewModel>();
            CreateMap<Project, ProjectDetailViewModel>();
        }
    }
}
