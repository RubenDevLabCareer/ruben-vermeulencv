using CvBlazor.ViewModels;

namespace CvBlazor.Services
{
    public interface IContactInfoService
    {
        public Task<IList<ContactInfoViewModel>> Get();
        public string GetMailHref(ContactInfoViewModel contact);
        public string GetLinkedInHref(ContactInfoViewModel contact);
        public string GetTelHref(ContactInfoViewModel contact);

    }
}