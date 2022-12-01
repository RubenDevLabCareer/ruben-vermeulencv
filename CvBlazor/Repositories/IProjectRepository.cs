using CvBlazor.Models;

namespace CvBlazor.Repositories
{
    public interface IProjectRepository
    {
        public Task<IEnumerable<Project>> Get();
    }
}