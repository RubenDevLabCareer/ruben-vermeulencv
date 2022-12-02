using AutoMapper;
using CvBlazor.Repositories;
using CvBlazor.ViewModels;
using System.Text.RegularExpressions;

namespace CvBlazor.Services
{
    public class ContactInfoService : IContactInfoService
    {
        private readonly IContactInfoRepository _repo;
        private readonly IMapper _mapper;

        public ContactInfoService(IContactInfoRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<IList<ContactInfoViewModel>> Get()
        {
            return (await _repo.Get()).Select(ci => _mapper.Map<ContactInfoViewModel>(ci)).ToList();
        }

        public string GetLinkedInHref(ContactInfoViewModel contact)
        {
            return $"https://www.linkedin.com/in/{contact.LinkedIn}";
        }

        public string GetMailHref(ContactInfoViewModel contact)
        {
            return $"mailto:{contact.Email}";
        }

        public string GetTelHref(ContactInfoViewModel contact)
        {
            return contact.Tel != null
                ? $"tel:{Regex.Replace(contact.Tel, @"\s+", "")}"
                : string.Empty;
        }
    }
}
