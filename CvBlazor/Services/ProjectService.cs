using AutoMapper;
using CvBlazor.Repositories;
using CvBlazor.ViewModels;
using System.Text.RegularExpressions;

namespace CvBlazor.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _repo;
        private readonly IMapper _mapper;

        public ProjectService(IProjectRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<IList<ProjectBaseViewModel>> Get()
        {
            return (await _repo.Get()).Select(p => _mapper.Map<ProjectBaseViewModel>(p)).ToList();
        }

        public async Task<ProjectDetailViewModel?> GetByCode(string code)
        {
            var project = (await _repo.Get()).FirstOrDefault(p => p.Code == code);
            return _mapper.Map<ProjectDetailViewModel?>(project);
        }
    }
}
