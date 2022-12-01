using CvBlazor.Models;
using Microsoft.AspNetCore.Components;

namespace CvBlazor.ViewModels
{
    public class HomeProfileViewModel
    {
        public string ImageSrc { get; set; } = string.Empty;
        public MarkupString InnerHtml { get; set; } = new MarkupString();
        public IList<SkillChip> Skills { get; set; } = new List<SkillChip>();
    }
}
