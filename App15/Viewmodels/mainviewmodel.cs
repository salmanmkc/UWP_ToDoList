using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App15.Viewmodels
{
    class MainViewModel
    {
        private string newTaskName;
        private ObservableCollection<TaskViewModel> tasks = new ObservableCollection<TaskViewModel>();
        public string NewTaskName
        {
            get { return newTaskName; }
            set { newTaskName = value; }
        }

        public ObservableCollection<TaskViewModel> Tasks
        {
            get { return tasks; }
            set { tasks = value; }
        }

    internal class TaskViewModel
    {
            public string TaskName { get; set; }
            public bool IsComplete { get; set; }
    }
}
}
