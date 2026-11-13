using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;

namespace ModernDashboardApp.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<TaskItem> Tasks { get; }

        public int TotalTasks { get; set; }
        public int CompletedTasks { get; set; }
        public int OnTrack { get; set; }
        public int RiskCount { get; set; }

        public MainViewModel()
        {
            Tasks = new ObservableCollection<TaskItem>
            {
                new TaskItem { Title = "Website redesign", Category = "UX", DueDate = "Due today • 4:00 PM", Progress = 78, Status = "Active", AccentBrush = CreateBrush("#7C6AFC") },
                new TaskItem { Title = "Customer analytics", Category = "Data", DueDate = "Due Friday • 2:00 PM", Progress = 62, Status = "Review", AccentBrush = CreateBrush("#38BDF8") },
                new TaskItem { Title = "Backend migration", Category = "Engineering", DueDate = "Due Monday • 9:00 AM", Progress = 90, Status = "Ready", AccentBrush = CreateBrush("#34D399") },
                new TaskItem { Title = "Marketing campaign", Category = "Growth", DueDate = "Due Tuesday • 1:00 PM", Progress = 42, Status = "At risk", AccentBrush = CreateBrush("#FBBF24") }
            };

            TotalTasks = 128;
            CompletedTasks = 46;
            OnTrack = 120;
            RiskCount = 6;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private static Brush CreateBrush(string hex)
        {
            var color = (Color)ColorConverter.ConvertFromString(hex)!;
            return new SolidColorBrush(color);
        }
    }
}
