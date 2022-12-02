using CvBlazor.Models;

namespace CvBlazor.Repositories
{
    public class ProjectRepository : JsonRepository<Project>, IProjectRepository
    {
        public ProjectRepository(HttpClient client) : base(client, "data/projects.json")
        {
        }
    }
}
