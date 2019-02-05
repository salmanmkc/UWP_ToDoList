using App15.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace App15.Viewmodels
{
     class MainViewModel : INotifyPropertyChanged
    {
        
        private string newTaskName = "";
        private ObservableCollection<TaskViewModel> tasks = new ObservableCollection<TaskViewModel>();
        public string NewTaskName
        {
            get { return newTaskName; }
            set {
                if (newTaskName != value)
                {
                    newTaskName = value;
                    OnPropertyChanged(nameof(NewTaskName));
                }
            }
        }

        public ObservableCollection<TaskViewModel> Tasks
        {
            get { return tasks; }
            set { tasks = value; }
        }

        public AddTask CreateTask => new AddTask();

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        internal class TaskViewModel 
        {
            public string decoration;
            public string TaskName { get; set; }
            private bool complete;
            public bool IsCopmlete
            {
                get { return complete; }
                set { complete = value; }
            }

            //public string Decoration
            //{
            //    get { return decoration; }
            //    set { if (IsComplete == true) decoration = "Strikethrough";
            //        else decoration = "";}
            //}

            public BitmapImage image { get; set; }

        }
}
}
