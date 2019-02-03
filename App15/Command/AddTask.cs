using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using App15.Viewmodels;
using Windows.UI.Popups;

namespace App15.Command
{
    class AddTask : ICommand
    {
        public event EventHandler CanExecuteChanged;


        public bool CanExecute(object parameter)
        {
            return true;
        }

        public async void Execute(object parameter)
        {
            if (parameter is MainViewModel viewModel)
            {
                if (viewModel.NewTaskName == "")
                {
                    var dialog = new MessageDialog("Please enter a task name");
                    dialog.Commands.Add(new UICommand { Label = "Ok", Id = 0 });
                    dialog.Title = "No task to add";
                    await dialog.ShowAsync();
                }
                else
                {
                    viewModel.Tasks.Add(new MainViewModel.TaskViewModel { IsComplete = false, TaskName = viewModel.NewTaskName });
                    viewModel.NewTaskName = "";
                    CanExecuteChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }
    }
}
