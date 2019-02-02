using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using App15.Viewmodels;

namespace App15.Command
{
    class AddTask : ICommand
    {
        public event EventHandler CanExecuteChanged;


        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is MainViewModel viewModel)
            {
                viewModel.Tasks.Add(new MainViewModel.TaskViewModel { IsComplete = false, TaskName = viewModel.NewTaskName });
                viewModel.NewTaskName = "";   
                CanExecuteChanged?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
