using CvBlazor.ViewModels;

namespace CvBlazor.Services
{
    public interface IMainProfileService
    {
        public Task<HomeProfileViewModel> GetHome();
        public Task<HeaderProfileViewModel> GetHeader();
    }
}
