using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Reminder.View_model
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        #region Data
        private ObservableCollection<NotifyData> addItem;
        private int id;
        private string info;
        private DateTime dateTime;
        private int interval;
        private int repeats;
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

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
            addItem = new ObservableCollection<NotifyData>
            {
                new NotifyData(Id, Info, Interval, DateTime, Repeats)
            };
        }

        #endregion
    }
}
