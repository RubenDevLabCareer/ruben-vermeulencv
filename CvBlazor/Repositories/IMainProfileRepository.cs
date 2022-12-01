using CvBlazor.Models;

namespace CvBlazor.Repositories
{
    public interface IMainProfileRepository
    {
        public Task<IEnumerable<MainProfile>> Get();
    }
}