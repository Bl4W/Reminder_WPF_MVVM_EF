using System.Windows;
using Reminder.View_model;

namespace Reminder
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowViewModel main = new MainWindowViewModel();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }

        private void AddNotify_Click(object sender, RoutedEventArgs e)
        {
            main.AddNotify();
        }
    }
}
