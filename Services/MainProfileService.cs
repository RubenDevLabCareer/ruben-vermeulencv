using AutoMapper;
using CvBlazor.Repositories;
using CvBlazor.ViewModels;

namespace CvBlazor.Services
{
    public class MainProfileService : IMainProfileService
    {
        private readonly IMainProfileRepository _profileRepo;
        private readonly IMapper _mapper;

        public MainProfileService(IMainProfileRepository profileRepo, IMapper mapper)
        {
            _mapper = mapper;
            _profileRepo = profileRepo;
        }

        public async Task<HomeProfileViewModel> GetHome()
        {
            return await Get<HomeProfileViewModel>() ?? new HomeProfileViewModel();
        }

        public async Task<HeaderProfileViewModel> GetHeader()
        {
            return await Get<HeaderProfileViewModel>() ?? new HeaderProfileViewModel();
        }

        private async Task<T?> Get<T>()
        {
            return _mapper.Map<T>((await _profileRepo.Get()).FirstOrDefault());
        }

    }
}
