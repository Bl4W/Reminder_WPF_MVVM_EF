using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Reminder.Database;
using System.Windows.Controls;

namespace Reminder.View_model
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        #region Data
        private ObservableCollection<Notify> notifyData;
        private int id;
        private string info;
        private DateTime dateTime;
        private int interval;
        private int repeats;
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        DatabaseLogic database = new DatabaseLogic();

        #region Properties
        public string Info
        {
            get => info;
            set
            {
                info = value;
                OnPropertyChange();
            }
        }

        public DateTime DateTime
        {
            get => dateTime;
            set
            {
                dateTime = value;
                OnPropertyChange();
            }
        }

        public int Interval
        {
            get => interval;
            set
            {
                interval = value;
                OnPropertyChange();
            }
        }

        public int Repeats
        {
            get => repeats;
            set
            {
                repeats = value;
                OnPropertyChange();
            }
        }

        public int Id
        {
            get => id;
            set
            {
                id = value;
                OnPropertyChange();
            }
        }
        #endregion

        #region Methods
        public void OnPropertyChange([CallerMemberName] string memberName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(memberName));
        }

        public void AddNotify()
        {
            database.SaveNotify(Id, Info, Interval, DateTime, Repeats);
        }

        public void Minimalize(MainWindow main)
        {
            main.Hide();
        }

        public void DeleteItem(ListBox listBox)
        {
            listBox.SelectedItems.Remove(listBox.SelectedItem);
        }
        

        #endregion
    }
}
