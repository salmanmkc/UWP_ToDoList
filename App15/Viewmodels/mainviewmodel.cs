using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App15.Viewmodels
{
    class MainViewModel
    {
        private string newTaskName;
        public string NewTaskName { get; set; }
        public ObservableCollection<Task> = new ObservableCollection<Task>{
            set;
            get;
        }
        
    }
}
