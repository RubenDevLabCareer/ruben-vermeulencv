using CvBlazor.Models;

namespace CvBlazor.Repositories
{
    public class ContactInfoRepository : JsonRepository<ContactInfo>, IContactInfoRepository
    {
        public ContactInfoRepository(HttpClient client) : base(client, "data/contact.json")
        {
        }
    }
}
