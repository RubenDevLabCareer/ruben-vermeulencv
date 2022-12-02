using CvBlazor.Models;

namespace CvBlazor.Repositories
{
    public interface IContactInfoRepository
    {
        public Task<IEnumerable<ContactInfo>> Get();
    }
}