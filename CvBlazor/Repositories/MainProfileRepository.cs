using CvBlazor.Models;

namespace CvBlazor.Repositories
{
    public class MainProfileRepository : JsonRepository<MainProfile>, IMainProfileRepository
    {
        public MainProfileRepository(HttpClient client) : base(client, "data/mainProfile.json")
        {
        }
    }
}
