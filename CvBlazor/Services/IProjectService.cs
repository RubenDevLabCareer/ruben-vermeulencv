using CvBlazor.ViewModels;

namespace CvBlazor.Services
{
    public interface IProjectService
    {
        public Task<IList<ProjectBaseViewModel>> Get();
        public Task<ProjectDetailViewModel> GetByCode(string code);
    }
}