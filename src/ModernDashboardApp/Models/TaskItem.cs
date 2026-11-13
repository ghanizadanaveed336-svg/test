using System.Windows.Media;

namespace ModernDashboardApp
{
    public class TaskItem
    {
        public string Title { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string DueDate { get; set; } = string.Empty;
        public int Progress { get; set; }
        public string Status { get; set; } = string.Empty;
        public Brush AccentBrush { get; set; } = Brushes.MediumPurple;
    }
}
