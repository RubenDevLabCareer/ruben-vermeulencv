namespace CvBlazor.ViewModels
{
    public class TimelineNodeViewModel
    {
        public string Title { get; set; } = string.Empty;
        public string SubTitle { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageSrc { get; set; } = string.Empty;
        public NodeType Type { get; set; }
        public DateTime StartDate { get; set; } = DateTime.MinValue;
        public DateTime? EndDate { get; set; }
    }

    public enum NodeType
    {
        Studies = 0,
        WorkExperience = 1
    }
}
