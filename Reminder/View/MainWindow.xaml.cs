using System.Windows;
using Reminder.View_model;

namespace Reminder
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowViewModel mainVM = new MainWindowViewModel();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }

        private void AddNotify_Click(object sender, RoutedEventArgs e)
        {
            mainVM.AddNotify();
        }

        private void Minimalize_Click(object sender, RoutedEventArgs e)
        {
            mainVM.Minimalize(this);
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            mainVM.DeleteItem(notifyListBox);
        }
    }
}
