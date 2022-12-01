using Microsoft.AspNetCore.Components;

namespace CvBlazor.Models
{
    public class MainProfile
    {
        public string Name { get; set; } = string.Empty;
        public string ImageSrc { get; set; } = string.Empty;
        public string InnerHtml { get; set; } = string.Empty;
        public IList<SkillChip> Skills { get; set; } = new List<SkillChip>();
    }
}
