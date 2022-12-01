namespace CvBlazor.Models
{
    public class TimelineNode
    {
        public string Title { get; set; } = string.Empty;
        public string SubTitle { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageSrc { get; set; } = string.Empty;
        public int Type { get; set; }
        public string StartDate { get; set; } = string.Empty;
        public string? EndDate { get; set; }
    }
}
