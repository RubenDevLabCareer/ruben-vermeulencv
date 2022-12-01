using AutoMapper;
using CvBlazor.Models;
using CvBlazor.ViewModels;

namespace CvBlazor.Mapper
{
    public class ContactInfoMapper : Profile
    {
        public ContactInfoMapper()
        {
            CreateMap<ContactInfo, ContactInfoViewModel>();
        }
    }
}
